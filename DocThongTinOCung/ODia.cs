using System;
using System.Windows.Forms;
using System.Management;
using System.Runtime.InteropServices;

namespace DocThongTinOCung
{
    public partial class ODia : Form
    {
        public ODia()
        {
            InitializeComponent();
            ManagementObjectSearcher search = new ManagementObjectSearcher("select * from Win32_LogicalDisk");
            foreach (ManagementObject disk in search.Get())
            {
                cbbODia.Items.Add(disk["DeviceID"].ToString());
            }
        }
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern bool GetDiskFreeSpace(string lpRootPathName,
           out uint lpSectorsPerCluster,
           out uint lpBytesPerSector,
           out uint lpNumberOfFreeClusters,
           out uint lpTotalNumberOfClusters);
        private void ODia_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        
        private void cbbODia_SelectedIndexChanged(object sender, EventArgs e)
        {

            uint SectorsPerCluster;
            uint BytesPerSector;
            uint NumberOfFreeClusters;
            uint TotalNumberOfClusters;
            string nameODia = cbbODia.Text;
            GetDiskFreeSpace(nameODia, out SectorsPerCluster, out BytesPerSector,
                out NumberOfFreeClusters, out TotalNumberOfClusters);

            ManagementObject data = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + nameODia + "\"");
            data.Get();
            if (data["VolumeName"] == null)
            {
                MessageBox.Show("Đây là partition không có thông tin ");
            }
            else
            {                

                lbNameODia.Text = data["VolumeName"].ToString()+" ("+nameODia+")";                                                  // tên ổ đĩa
                progressBar1.Maximum = 100;                                                                                         // dung lượng lớn nhất    
                double tong = Convert.ToDouble(data["Size"]);                                                                       // tổng dung lượng ổ đĩa                                                    
                double trong = Convert.ToDouble(data["FreeSpace"]);                                                                 // dung lượng trống
                double dung = tong - trong;                                                                                         // dung lượng đang dùng                    
                progressBar1.Value = Convert.ToInt32(dung/tong*100);                                                                // cho vào cái chứa
                lbChiTiet.Text = Math.Round(trong/Math.Pow(2,30), 2) + "GB free of "+Math.Round(tong/Math.Pow(2,30),2)+"GB";        // hiện dữ liệu
                
                tbNamePhanVung.Text = data["VolumeName"].ToString();                                                                // TÊN PHÂN VÙNG
                tbDinhDang.Text = data["FileSystem"].ToString();                                                                    // Tên đinh dạng
                tbSectorsCluster.Text = SectorsPerCluster.ToString();                                                               // số SectorsPerCluster
                tbCluster.Text= TotalNumberOfClusters.ToString();                                                                   // số Clusters        
                tbSerialPV.Text = data["VolumeSerialNumber"].ToString();                                                            // số Serial
                tbDungLuongTrong.Text =Math.Round( trong / Math.Pow(2, 30),2) + "GB";
                tbDungLuongDung.Text = Math.Round(dung / Math.Pow(2, 30),2) + "GB";
                tbTongDungLuong.Text = Math.Round(tong / Math.Pow(2, 30),2) + "GB";
            }
        }

        private void ODia_Load(object sender, EventArgs e)
        {

        }
    }
}
