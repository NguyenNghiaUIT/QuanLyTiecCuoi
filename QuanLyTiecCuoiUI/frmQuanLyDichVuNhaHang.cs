using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using System.IO;

namespace QuanLyTiecCuoiUI
{
    public partial class frmQuanLyDichVuNhaHang : Form
    {
        enum STATEBUTTON
        {
            INSERT,
            UPDATE,
            REMOVE,
            DEFAULT,
        }
        private STATEBUTTON StateButton = STATEBUTTON.DEFAULT;
        private string IDTable = "DV";
        private ImageList imgListDichVu = new ImageList();
        private DataTable resultDichVuTable;
        private int itemSelect = -2;
        private string ImageLocationPath = string.Empty;
        private string ImageInstance = string.Empty;
        #region Get Next ID
        //Get next ID 
        //Convert Number to string for index
        private string ConvertNumber(int state)
        {
            if (state <= 9) return '0' + state.ToString();
            else
                return state.ToString();
        }
        //Get next index in table
        private string GetNextID(DataTable result)
        {
            try
            {
                return IDTable + (ConvertNumber(Int32.Parse(result.Rows[result.Rows.Count - 1].ItemArray[0].ToString().Substring(2)) + 1));
            }
            catch (Exception ex)
            {
                return IDTable + "01";
            }
        }
        #endregion

        #region Setup List View
        private void GetDataDichVuCurrent()
        {
            resultDichVuTable = BUS_DichVuNhaHang.GetDataDichVu();
        }
        private void SetupImageListView()
        {
            GetDataDichVuCurrent();
            lstHinhAnh.View = View.Tile;
            lstHinhAnh.TileSize = new Size(230, 90);

            //Get list Image
            for (int i = 0; i < resultDichVuTable.Rows.Count; i++)
            {
                try
                {
                    imgListDichVu.Images.Add(resultDichVuTable.Rows[i][1].ToString(), Image.FromFile(@"DanhSachDichVu\" + resultDichVuTable.Rows[i][4].ToString()));
                }
                catch (Exception ex)
                {
                    imgListDichVu.Images.Add(resultDichVuTable.Rows[i][1].ToString(), Image.FromFile(@"DanhSachDichVu\unknow.png"));
                }
                imgListDichVu.ImageSize = new Size(70, 70);
                lstHinhAnh.LargeImageList = imgListDichVu;
            }

            //Add list Image to list view
            for (int i = 0; i < imgListDichVu.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = resultDichVuTable.Rows[i][1].ToString();
                lstHinhAnh.Items.Add(item);
            }
        }
        #endregion

        #region Setup Control enable and disable
        private void EnableStateButton(bool state)
        {
            btnLuu.Enabled = btnHuy.Enabled = state;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = !state;
            btnTimHinh.Enabled = btnXoaHinh.Enabled = state;
        }
        private void EnableStateTextBox(bool state)
        {
            txtDonGia.ReadOnly = txtGhiChu.ReadOnly = txtTenDichVu.ReadOnly = state;
        }
        #endregion

        #region Event List View Hinh Anh
        private void lstHinhAnh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StateButton == STATEBUTTON.INSERT) return;
            try
            {
                //MessageBox.Show(itemSelect.ToString() + " " + lstHinhAnh.FocusedItem.Index.ToString());
                if (lstHinhAnh.FocusedItem.Index == -1) return;
                int currentItem = itemSelect = lstHinhAnh.FocusedItem.Index;
                lblThongTinMaDichVu.Text = resultDichVuTable.Rows[currentItem][0].ToString();
                txtTenDichVu.Text = resultDichVuTable.Rows[currentItem][1].ToString();
                txtDonGia.Text = resultDichVuTable.Rows[currentItem][2].ToString();
                txtGhiChu.Text = resultDichVuTable.Rows[currentItem][3].ToString();
                lblThongTinHinhAnh.Text = resultDichVuTable.Rows[currentItem][4].ToString();
                ptrHinhAnh.ImageLocation = @"DanhSachDichVu\" + resultDichVuTable.Rows[currentItem][4].ToString();
                ptrHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao tác thất bại " + itemSelect.ToString());
                return;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Set state Button
            StateButton = STATEBUTTON.INSERT;
            //Enable control
            EnableStateButton(true);
            EnableStateTextBox(false);
            //Reset Value
            lblThongTinHinhAnh.Text = string.Empty;
            txtDonGia.Text = txtGhiChu.Text = txtTenDichVu.Text = string.Empty;
            lblThongTinMaDichVu.Text = GetNextID(resultDichVuTable);
            ptrHinhAnh.Image = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Update region 
            if (itemSelect >= 0)
            {
                //Set state Button
                StateButton = STATEBUTTON.UPDATE;
                //Enable control
                EnableStateButton(true);
                EnableStateTextBox(false);
                ImageInstance = resultDichVuTable.Rows[itemSelect][4].ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            StateButton = STATEBUTTON.REMOVE;
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa dịch vụ: " + resultDichVuTable.Rows[itemSelect][1].ToString(), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                try
                {
                    DTO_DichVu dichvu = new DTO_DichVu();
                    dichvu.MaDichVu = resultDichVuTable.Rows[itemSelect][0].ToString();
                    dichvu.HinhAnh = resultDichVuTable.Rows[itemSelect][4].ToString();

                    //Check State of Image 
                    int stateRowEffect = BUS_DichVuNhaHang.DeleteRecordEffect(dichvu);
                    bool DeleteState = BUS_DichVuNhaHang.Delete(dichvu);
                    if (DeleteState)
                    {
                        //Delete image in data
                        if (stateRowEffect > 1 && dichvu.HinhAnh != "unknow")
                        {
                            imgListDichVu.Images.RemoveAt(itemSelect);
                            lstHinhAnh.Items.RemoveAt(itemSelect);
                        }
                        else
                            DeleteImage();
                        resultDichVuTable = BUS_DichVuNhaHang.GetDataDichVu();
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                        MessageBox.Show("Xóa thất bại");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thao tác xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                itemSelect = -1;
            }         
        }

        private void ShowNotification()
        {
            lblSaoDichVu.Text = lblSaoDonGia.Text = "*";
            lblThongBao.Text = "(*) không được để trống";
        }
        private void HideNotification()
        {
            lblSaoDichVu.Text = lblSaoDonGia.Text = lblThongBao.Text = String.Empty;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Check state Insert
            if (StateButton == STATEBUTTON.INSERT)
            {
                //Save image Region
                bool stateSaveImage = true;
                string pathImage = ImageLocationPath;
                try
                {
                    if (lblThongTinHinhAnh.Text == string.Empty) lblThongTinHinhAnh.Text = "unknow.png";
                    if (File.Exists(@"DanhSachDichVu\" + lblThongTinHinhAnh.Text))
                    {
                        stateSaveImage = false;
                    }
                }
                catch (Exception ex)
                {
                    lblThongTinHinhAnh.Text = "unknow.png";
                }
                //Insert Region
                DTO_DichVu dichvu = new DTO_DichVu();
                if (txtTenDichVu.Text == string.Empty || txtDonGia.Text == string.Empty)
                {
                    ShowNotification();
                    return;
                }

                //Add information 
                dichvu.MaDichVu = lblThongTinMaDichVu.Text;
                dichvu.TenDichVu = txtTenDichVu.Text;
                try
                {
                    dichvu.DonGia = Convert.ToDecimal(txtDonGia.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Đơn giá nhập lỗi ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dichvu.GhiChu = txtGhiChu.Text;

                //Insert name Hinh Anh
                if (lblThongTinHinhAnh.Text == "") dichvu.HinhAnh = "unknow.png";
                else
                    dichvu.HinhAnh = lblThongTinHinhAnh.Text;

                //Insert region
                bool InsertState = BUS_DichVuNhaHang.Insert(dichvu);
                if (InsertState)
                {
                    if (stateSaveImage)
                    {
                        try
                        {
                            string pathFolderProject = @"DanhSachDichVu\";
                            var path = Path.Combine(pathFolderProject, Path.GetFileName(pathImage));
                            File.Copy(pathImage, path);
                            ImageLocationPath = string.Empty;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Thao tác thêm ảnh vào CSDL thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    resultDichVuTable = BUS_DichVuNhaHang.GetDataDichVu();
                    InsertNewImage(dichvu);
                    MessageBox.Show("Thêm dịch vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                    MessageBox.Show("Thêm dịch vụ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);

                //Reset State Region
                lblThongTinHinhAnh.Text = string.Empty;
                txtDonGia.Text = txtGhiChu.Text = txtTenDichVu.Text = string.Empty;
                lblThongTinMaDichVu.Text = string.Empty;
                ptrHinhAnh.Image = null;
                StateButton = STATEBUTTON.DEFAULT;
                EnableStateButton(false);
                EnableStateTextBox(true);
                HideNotification();
            }
            else //Update state
            if (StateButton == STATEBUTTON.UPDATE)
            {
                //State image now 
                string pathImage = resultDichVuTable.Rows[itemSelect][4].ToString();
                //Check state region 
                DTO_DichVu dichvu = new DTO_DichVu();
                if (txtTenDichVu.Text == string.Empty || txtDonGia.Text == string.Empty)
                {
                    ShowNotification();
                    return;
                }
                dichvu.MaDichVu = lblThongTinMaDichVu.Text;
                dichvu.TenDichVu = txtTenDichVu.Text;
                try
                {
                    dichvu.DonGia = Convert.ToDecimal(txtDonGia.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Đơn giá sửa bị lỗi ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dichvu.GhiChu = txtGhiChu.Text;
                //Insert name Hinh Anh
                if (lblThongTinHinhAnh.Text == "") dichvu.HinhAnh = "unknow.png";
                else
                    dichvu.HinhAnh = lblThongTinHinhAnh.Text;

                bool UpdateState = BUS_DichVuNhaHang.Update(dichvu);
                DTO_DichVu PreviousDichVu = new DTO_DichVu();
                PreviousDichVu.HinhAnh = ImageInstance;
                int RecordEffect = BUS_DichVuNhaHang.DeleteRecordEffect(PreviousDichVu);
                if (UpdateState)
                {
                    //Check state image with image in DB
                    string pathCheck = ImageLocationPath;

                    if (lblThongTinHinhAnh.Text != pathImage)
                    {
                        if (dichvu.HinhAnh != "unknow.png")
                        {
                            //Delete old image and insert new image vào Database
                            try
                            {
                                //copy new image
                                string pathFolderProject = @"DanhSachDichVu\";
                                var path = Path.Combine(pathFolderProject, Path.GetFileName(pathCheck));
                                File.Copy(pathCheck, path);
                            }
                            catch (Exception ex)
                            {

                            }
                            UpdateImage(dichvu);
                        }
                        else
                        {
                            int lastIndex = imgListDichVu.Images.Count;
                            imgListDichVu.Images[itemSelect].Dispose();
                            imgListDichVu.Images.Add(Image.FromFile(@"DanhSachDichVu\unknow.png"));
                            imgListDichVu.Images[itemSelect] = imgListDichVu.Images[lastIndex];
                            imgListDichVu.Images.RemoveAt(lastIndex);
                            lstHinhAnh.LargeImageList = imgListDichVu;
                            lstHinhAnh.Items[itemSelect].Text = dichvu.TenDichVu;
                            lstHinhAnh.Refresh();
                        }
                    }
                    else
                    {
                        lblThongTinHinhAnh.Text = pathImage;
                        lstHinhAnh.Items[itemSelect].Text = dichvu.TenDichVu;
                        lstHinhAnh.Refresh();
                    }

                    resultDichVuTable = BUS_DichVuNhaHang.GetDataDichVu();

                    //Reset State Region
                    lstHinhAnh_SelectedIndexChanged(sender, e);
                    ptrHinhAnh.Image = null;
                    StateButton = STATEBUTTON.DEFAULT;
                    EnableStateButton(false);
                    EnableStateTextBox(true);
                    HideNotification();
                    ImageLocationPath = string.Empty;
                    MessageBox.Show("Cập nhật thành công ");
                              
                }
                else
                    MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Reset all state 
            lblThongTinHinhAnh.Text = string.Empty;
            txtDonGia.Text = txtGhiChu.Text = txtTenDichVu.Text = string.Empty;
            lblThongTinMaDichVu.Text = string.Empty;
            ptrHinhAnh.Image = null;
            StateButton = STATEBUTTON.DEFAULT;
            EnableStateButton(false);
            EnableStateTextBox(true);
            HideNotification();
            lstHinhAnh_SelectedIndexChanged(sender, e);
        }
        private void btnTimHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"C:\";
            dialog.Filter = "Image Files(*.jpg,*.jpeg,*.png)|*.jpg;*.jpeg;*.png";
            dialog.DefaultExt = ".png";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ImageLocationPath = dialog.FileName;
                lblThongTinHinhAnh.Text = dialog.SafeFileName;
                ptrHinhAnh.ImageLocation = ImageLocationPath;
                ptrHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnXoaHinh_Click(object sender, EventArgs e)
        {
            ImageLocationPath = lblThongTinHinhAnh.Text = string.Empty;
            ptrHinhAnh.Image = Image.FromFile(@"DanhSachDichVu\unknow.png");
        }
        #endregion

        #region Event ImageList Insert, Update, Remove
        private void InsertNewImage(DTO_DichVu dichvu)
        {
            try
            {
                imgListDichVu.Images.Add(dichvu.TenDichVu, Image.FromFile(@"DanhSachDichVu\" + dichvu.HinhAnh));
                imgListDichVu.ImageSize = new Size(70, 70);
                lstHinhAnh.LargeImageList = imgListDichVu;
                lstHinhAnh.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiển thị hình ảnh thất bại");
            }

            try
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = resultDichVuTable.Rows.Count - 1;
                item.Text = dichvu.TenDichVu;
                lstHinhAnh.Items.Add(item);
                lstHinhAnh.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gán hình ảnh vào List thất bại");
            }
        }

        private void DeleteImage()
        {
            try
            {
                imgListDichVu.Images.RemoveAt(itemSelect);
                lstHinhAnh.Items.RemoveAt(itemSelect);

                string path = @"DanhSachDichVu\" + resultDichVuTable.Rows[itemSelect][4].ToString();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                if (resultDichVuTable.Rows[itemSelect][4].ToString() != "unknow.png")
                    File.Delete(path);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Thao tác ảnh thất bại");
                return;
            }
        }

        private void UpdateImage(DTO_DichVu dichvu)
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
                lstHinhAnh.Items[itemSelect].Text = dichvu.TenDichVu;
                lstHinhAnh.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật hình ảnh thất bại");
            }
        }

        #endregion
        public frmQuanLyDichVuNhaHang()
        {
            InitializeComponent();
        }

        private void frmQuanLyDichVuNhaHang_Load(object sender, EventArgs e)
        {
            SetupImageListView();
            //Setup UI
            lblThongTinMaDichVu.Text = string.Empty;
            lblThongTinHinhAnh.Text = string.Empty;
            EnableStateTextBox(true);
            EnableStateButton(false);
            //Set Token for important Attribute  
            HideNotification();
        }
    }
}
