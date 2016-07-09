using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiecCuoiUI
{
    public partial class frmQuanLyDichVu : Form
    {
        private STATE currentState;
        private DataTable ResultTable;
        private ImageList imgListDichVu = new ImageList();
        private int itemSelect = -2;
        private string ImageLocationPath = string.Empty;
        private string ImageInstance = string.Empty;
        enum STATE
        {
            WAITING,
            INSERT,
            EDIT,
            CELLSELECTED
        }

        public frmQuanLyDichVu()
        {
            InitializeComponent();
        }
        private void frmQuanLyDichVu_Load(object sender, EventArgs e)
        {
            //Setup UI
            SetupImageListView();
            this.currentState = STATE.WAITING;
            EnableFunctionsControl();
        }

        #region Function
        private void EnableInputsControl(bool flag)
        {            
            txtTenDichVu.Enabled = txtDonGia.Enabled = txtGhiChu.Enabled = flag;
        }
        private void EnableFunctionsControl()
        {
            if (this.currentState == STATE.WAITING)
            {
                lstHinhAnh.SelectedIndices.Clear();
                btnThem.Enabled = true;
                btnLuu.Enabled = btnHuy.Enabled = btnSua.Enabled = btnXoa.Enabled = btnChonAnh.Enabled = btnXoaAnh.Enabled = false;
                EnableInputsControl(false);
                ClearInputs();
            }
            else if (currentState == STATE.INSERT)
            {
                lstHinhAnh.SelectedIndices.Clear();
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
                btnLuu.Enabled = btnHuy.Enabled = btnChonAnh.Enabled = btnXoaAnh.Enabled = true;
                EnableInputsControl(true);
                ClearInputs();
            }
            else if (this.currentState == STATE.EDIT)
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
                btnLuu.Enabled = btnHuy.Enabled = true;
                btnChonAnh.Enabled = btnXoaAnh.Enabled = true;
                EnableInputsControl(true);
            }
            else if (this.currentState == STATE.CELLSELECTED)
            {
                btnLuu.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnHuy.Enabled = true;
                EnableInputsControl(false);
            }
        }
        private void ClearInputs()
        {
            txtDonGia.Text = txtTenDichVu.Text = txtGhiChu.Text = string.Empty;
            ptrHinhAnh.Image = null;
            lbThongTinHinhAnh.Text = string.Empty;
            ptrHinhAnh.ImageLocation = string.Empty;
        }
        private bool InputsAreNull()
        {
            if (txtTenDichVu.Text == "" || txtDonGia.Text == "")
                return true;
            return false;
        }
        //Chỉ nhập số_Đơn giá
        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion            

        #region Button event
        private void btnThem_Click(object sender, EventArgs e)
        {
            //Set state btnThem
            this.currentState = STATE.INSERT;
            EnableFunctionsControl();
            txtTenDichVu.Focus();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            //Set state Button
            this.currentState = STATE.EDIT;
            EnableFunctionsControl();
            ImageInstance = ResultTable.Rows[itemSelect][3].ToString();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa dịch vụ này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                try
                {
                    DTO_DichVu dichVu = new DTO_DichVu();
                    dichVu.HinhAnh = ResultTable.Rows[itemSelect][3].ToString();
                    dichVu.MaDichVu = Int32.Parse(ResultTable.Rows[itemSelect][0].ToString());

                    //Check State of Image
                    bool DeleteState = BUS_DichVu.DeleteDichVu(dichVu);
                    if (DeleteState)
                    {
                        DeleteImage();

                        imgListDichVu.Dispose();
                        lstHinhAnh.Items.Clear();
                        SetupImageListView();

                        MessageBox.Show("Xóa thành công!");
                        this.currentState = STATE.WAITING;
                        EnableFunctionsControl();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!\nItem vẫn đang được sử dụng ở PhieuDatBan, vui lòng kiểm tra lại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thao tác xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (InputsAreNull())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ!");
            }

            //INSERT State
            else if (this.currentState == STATE.INSERT)
            {
                //Check txtDonGia
                double parsedValue;
                if (!double.TryParse(txtDonGia.Text, out parsedValue))
                {
                    MessageBox.Show("Đơn giá - chỉ chấp nhận định dạng số!");
                    txtDonGia.ResetText();
                    return;
                }
                else if (txtDonGia.Text.Length > 18)
                {
                    MessageBox.Show("Đơn giá - không vượt quá 18 chữ số!");
                    txtDonGia.ResetText();
                    return;
                }

                //Save image
                bool stateSaveImage = true;
                string newImage = ImageLocationPath;
                try
                {
                    if (lbThongTinHinhAnh.Text == "")
                    {
                        lbThongTinHinhAnh.Text = "Unknow.png";
                    }
                    if (File.Exists(@"DanhSachDichVu\" + lbThongTinHinhAnh.Text))
                    {
                        stateSaveImage = false;
                    }
                }
                catch (Exception ex)
                {
                    lbThongTinHinhAnh.Text = "Unknow.png";
                }

                //DTO Information
                string nameOfImage = (BUS_DichVu.LastIndex() + 1).ToString() + Path.GetExtension(newImage);
                DTO_DichVu dichVu = new DTO_DichVu();
                dichVu.TenDichVu = txtTenDichVu.Text;
                dichVu.DonGia = Convert.ToDecimal(txtDonGia.Text);
                dichVu.GhiChu = txtGhiChu.Text;
                if (lbThongTinHinhAnh.Text == "Unknow.png")
                {
                    dichVu.HinhAnh = "Unknow.png";
                }
                else
                {
                    dichVu.HinhAnh = nameOfImage;
                }

                //INSERT
                bool InsertState = BUS_DichVu.InsertDichVu(dichVu);
                if (InsertState)
                {
                    //Copy image to folder project                
                    if (stateSaveImage)
                    {
                        try
                        {
                            string desFileName = Path.Combine(@"DanhSachDichVu\", nameOfImage);
                            File.Copy(newImage, desFileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Thao tác thêm ảnh vào CSDL thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    ResultTable = BUS_DichVu.GetDataTableDichVu();
                    InsertNewImage(dichVu);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);

                //lstHinhAnh.Refresh();
                this.currentState = STATE.WAITING;
                EnableFunctionsControl();
                ClearInputs();
            }

            //UPDATE state
            else if (this.currentState == STATE.EDIT)
            {
                //Check txtDonGia - Number only
                double parsedValue;
                if (!double.TryParse(txtDonGia.Text, out parsedValue))
                {
                    MessageBox.Show("Đơn giá - chỉ chấp nhận định dạng số!");
                    txtDonGia.ResetText();
                    return;
                }
                else if (txtDonGia.Text.Length > 18)
                {
                    MessageBox.Show("Đơn giá - không vượt quá 18 chữ số!");
                    txtDonGia.ResetText();
                    return;
                }

                //OldImage
                string OldImage = ResultTable.Rows[itemSelect][3].ToString();
                //NewImage
                string NewImage = ImageLocationPath;

                //DTO Information                
                DTO_DichVu dichVu = new DTO_DichVu();
                dichVu.MaDichVu = Int32.Parse(ResultTable.Rows[itemSelect][0].ToString());
                dichVu.TenDichVu = txtTenDichVu.Text;
                dichVu.DonGia = Convert.ToDecimal(txtDonGia.Text);
                dichVu.GhiChu = txtGhiChu.Text;
                string nameOfImage = dichVu.MaDichVu.ToString() + Path.GetExtension(NewImage);

                //name HinhAnh
                if (lbThongTinHinhAnh.Text == "")
                {
                    dichVu.HinhAnh = "Unknow.png";
                }
                else
                {
                    dichVu.HinhAnh = nameOfImage;
                }

                //UPDATE
                bool UpdateState = BUS_DichVu.UpdateDichVu(dichVu);
                if (UpdateState)
                {
                    //Check [NewImage] with [OldImage]

                    if (lbThongTinHinhAnh.Text != OldImage)
                    {
                        //DELETE OldImage and INSERT NewImage
                        if (dichVu.HinhAnh != "Unknow.png")
                        {
                            //DELETE OldImage
                            try
                            {
                                string path2 = @"DanhSachDichVu\" + OldImage;
                                GC.Collect();
                                GC.WaitForPendingFinalizers();
                                if (OldImage != "Unknow.png")
                                    File.Delete(path2);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Xoá ảnh thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                            }

                            //INSERT NewImage
                            try
                            {
                                string nameOfNewImage = dichVu.MaDichVu.ToString() + Path.GetExtension(NewImage);
                                string desFileName = Path.Combine(@"DanhSachDichVu\", nameOfNewImage);
                                File.Copy(NewImage, desFileName);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Thêm ảnh thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                            }
                            UpdateImage(dichVu);
                        }
                        else //dichVu.HinhAnh == "Unknow.png" => Xoá ảnh [prevImage] (OldImage)
                        {
                            //DELETE OldImage
                            try
                            {
                                string path2 = @"DanhSachDichVu\" + OldImage;
                                GC.Collect();
                                GC.WaitForPendingFinalizers();
                                if (OldImage != "Unknow.png")
                                    File.Delete(path2);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Xoá ảnh thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                            }

                            int lastIndex = imgListDichVu.Images.Count;
                            imgListDichVu.Images[itemSelect].Dispose();
                            imgListDichVu.Images.Add(Image.FromFile(@"DanhSachDichVu\Unknow.png"));
                            imgListDichVu.Images[itemSelect] = imgListDichVu.Images[lastIndex];
                            imgListDichVu.Images.RemoveAt(lastIndex);
                            lstHinhAnh.LargeImageList = imgListDichVu;
                            lstHinhAnh.Items[itemSelect].Text = dichVu.TenDichVu;
                            lstHinhAnh.Refresh();
                        }
                    }
                    else
                    {
                        lbThongTinHinhAnh.Text = OldImage;
                        lstHinhAnh.Items[itemSelect].Text = dichVu.TenDichVu;
                        lstHinhAnh.Refresh();
                    }

                    ResultTable = BUS_DichVu.GetDataTableDichVu();
                    this.currentState = STATE.WAITING;
                    EnableFunctionsControl();
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (this.currentState == STATE.INSERT || this.currentState == STATE.EDIT)
            {
                DialogResult confirm = MessageBox.Show("Bạn có muốn hủy không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    this.currentState = STATE.WAITING;
                    EnableFunctionsControl();
                }
                else if (confirm == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                this.currentState = STATE.WAITING;
                EnableFunctionsControl();
            }
        }
        #endregion

        #region Button group HinhAnh
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"C:\";
            dialog.Filter = "Image Files(*.jpg,*.jpeg,*.png)|*.jpg;*.jpeg;*.png";
            dialog.DefaultExt = ".png";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ImageLocationPath = dialog.FileName;
                lbThongTinHinhAnh.Text = dialog.SafeFileName;
                ptrHinhAnh.ImageLocation = dialog.FileName;
            }
        }

        private void btnXoaAnh_Click(object sender, EventArgs e)
        {
            lbThongTinHinhAnh.Text = string.Empty;
            ptrHinhAnh.ImageLocation = @"DanhSachDichVu\Unknow.png";
        }
        #endregion

        #region Event ImageList Insert, Edit, Delete
        private void InsertNewImage(DTO_DichVu dichVu)
        {
            try
            {
                imgListDichVu.Images.Add(dichVu.TenDichVu, Image.FromFile(@"DanhSachDichVu\" + dichVu.HinhAnh));
                imgListDichVu.ImageSize = new Size(90, 90);
                lstHinhAnh.LargeImageList = imgListDichVu;
                lstHinhAnh.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiển thị hình ảnh thất bại");
            }

            //Add item (text + index) to lstHinhAnh
            ListViewItem item = new ListViewItem();
            item.ImageIndex = ResultTable.Rows.Count - 1;
            item.Text = dichVu.TenDichVu;
            lstHinhAnh.Items.Add(item);
            lstHinhAnh.Refresh();
        }
        /// <summary>
        /// Delete image at itemSelect (from imgListDichVu, lstHinhAnh)
        /// </summary>
        private void DeleteImage()
        {
            try
            {
                //DELETE image
                string path = @"DanhSachDichVu\" + ResultTable.Rows[itemSelect][3].ToString();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                if (File.Exists(path))
                {
                    if (ResultTable.Rows[itemSelect][3].ToString() != "Unknow.png")
                    {
                        File.Delete(path);
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Xoá ảnh thất bại!");
                return;
            }
        }
        private void UpdateImage(DTO_DichVu dichVu)
        {
            try
            {
                ptrHinhAnh.Image = Image.FromFile(ImageLocationPath);
                int lastIndex = imgListDichVu.Images.Count;
                imgListDichVu.Images[itemSelect].Dispose();
                imgListDichVu.Images.Add(Image.FromFile(ImageLocationPath));

                imgListDichVu.Images[itemSelect] = imgListDichVu.Images[lastIndex];
                imgListDichVu.Images.RemoveAt(lastIndex);

                lstHinhAnh.LargeImageList = imgListDichVu;
                lstHinhAnh.Items[itemSelect].Text = dichVu.TenDichVu;
                lstHinhAnh.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật hình ảnh thất bại!");
            }
        }
        #endregion

        #region Setup ListView
        private void GetDataDichVuCurrent()
        {
            ResultTable = BUS_DichVu.GetDataTableDichVu();
        }
        private void SetupImageListView()
        {
            //lst image
            GetDataDichVuCurrent();
            lstHinhAnh.View = View.Tile;
            lstHinhAnh.TileSize = new Size(260, 100);

            //Get list Image
            for (int i = 0; i < ResultTable.Rows.Count; i++)
            {
                try
                {
                    imgListDichVu.Images.Add(ResultTable.Rows[i][1].ToString(), Image.FromFile(@"DanhSachDichVu\" + ResultTable.Rows[i][3].ToString()));
                }
                catch (Exception ex)
                {
                    imgListDichVu.Images.Add(ResultTable.Rows[i][1].ToString(), Image.FromFile(@"DanhSachDichVu\Unknow.png"));
                }

                imgListDichVu.ImageSize = new Size(90, 90);
                lstHinhAnh.LargeImageList = imgListDichVu;
            }

            //Add list Image to list view
            for (int i = 0; i < imgListDichVu.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = ResultTable.Rows[i][1].ToString();
                lstHinhAnh.Items.Add(item);
            }
        }
        #endregion

        private void lstHinhAnh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentState == STATE.INSERT)
                return;

            try
            {
                this.currentState = STATE.CELLSELECTED;
                EnableFunctionsControl();

                if (lstHinhAnh.FocusedItem.Index == -1) return;

                //itemSelect
                int currentItem = itemSelect = lstHinhAnh.FocusedItem.Index;
                txtTenDichVu.Text = ResultTable.Rows[currentItem][1].ToString();
                txtDonGia.Text = ResultTable.Rows[currentItem][2].ToString();
                txtGhiChu.Text = ResultTable.Rows[currentItem][4].ToString();
                lbThongTinHinhAnh.Text = ResultTable.Rows[currentItem][3].ToString();
                ptrHinhAnh.ImageLocation = @"DanhSachDichVu\" + ResultTable.Rows[currentItem][3].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao tác thất bại " + itemSelect.ToString());
                return;
            }
        }
    }
}
