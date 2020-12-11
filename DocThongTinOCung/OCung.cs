using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
namespace DocThongTinOCung
{
    public partial class OCung : Form
    {
        public OCung()
        {
            // giao diện
            InitializeComponent();
            // lấy tên ổ cứng cho vào ComboBox
            ManagementObjectSearcher objectSearcher = new ManagementObjectSearcher("Select * from Win32_DiskDrive");
            foreach (ManagementObject moDisk in objectSearcher.Get())
            {
                cbbOCung.Items.Add(moDisk["Name"].ToString());
            }
        }
        // khi tắt cái giao diện này thì sẽ quay lại giao diện củ
        private void OCung_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        // khi click ComboBox dữ liệu đổ ra
        private void cbbOCung_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameOCung = cbbOCung.Text;                                                                            // lấy tên ổ cứng hiện tại
            nameOCung = nameOCung.Remove(0, 4);                                                                          // bỏ dấu \\. \ đi                       
            ManagementObject data = new ManagementObject("Win32_DiskDrive.DeviceID=\"" + @"\\\\.\\" + nameOCung + "\""); // thực hiện câu lệnh để lấy dữ liệu
            data.Get();                                                                                                  // Lấy data của ổ cứng
            // đổ data :
            tBMaSP.Text = data["Model"].ToString();                                                                      // mã sản phẩm                     
            tBSerial.Text = data["SerialNumber"].ToString();                                                             // số srial 
            tBTrangThai.Text = data["Status"].ToString();                                                                // trạng thái                     
            tBPhanVung.Text = data["Partitions"].ToString();                                                             // Phân vùng             
            tBDungLuong.Text =Math.Round((Convert.ToDouble(data["Size"]) /(Math.Pow(2,30))), 2).ToString() + " GB";      // tổng dung lượng  của ổ cứng
            tBbytesSector.Text = data["BytesPerSector"].ToString();                                                      // số bytes/sector                                         
            tBSectorsTrack.Text = data["SectorsPerTrack"].ToString();                                                    // số sector/track     
            tBHead.Text = data["TotalHeads"].ToString();                                                                 // tổng số head                                         
            tBSoSectors.Text = data["TotalSectors"].ToString();                                                          // tổng số sectors
            tBSoTracks.Text = data["TotalTracks"].ToString();                                                            // tổng số strack                 
        }

    }
}
