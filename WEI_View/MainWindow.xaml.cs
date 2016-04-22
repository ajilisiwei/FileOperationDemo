using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WEI_Common;
using WEI_DAL;



namespace WEI_View
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private static List<Goods> list = new List<Goods>();
        public MainWindow()
        {
            InitializeComponent();
            DG_Goods.ItemsSource = list;
            RB_DefaultPath.IsChecked = true;
            TB_Path.IsEnabled = false;
            Btn_OpenPath.IsEnabled = false;
        }

        #region 1.TabIten1
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Reserach_Click(object sender, RoutedEventArgs e)
        {
            using (billiardEntities1 context = new billiardEntities1())
            {
                if (string.IsNullOrWhiteSpace(TB_Condition.Text.Trim())) return;
                int customerno = Convert.ToInt32(TB_Condition.Text);
                list = context.Goods.Where(g => g.MerId == customerno).ToList();
                DG_Goods.ItemsSource = list;
                LogHelper.WriteLog(typeof(Window),"Hello");
            }
        }

        /// <summary>
        /// 导出Excel文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_OutPutExcel_Click(object sender, RoutedEventArgs e)
        {
            switch (ExcelHelper.ExportDataGrid(DG_Goods))
            {
                case 1:
                    System.Windows.MessageBox.Show("导出Exce成功！");
                    break;
                case 3:
                    System.Windows.MessageBox.Show("导出Excel出错！");
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region 2.TabItem2
        /// <summary>
        /// 备份数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_BackUp_Click(object sender, RoutedEventArgs e)
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory + "test.bat";
            string currentDBFilePath = System.AppDomain.CurrentDomain.BaseDirectory + "test.sdf";
            if (!System.IO.File.Exists(path))
            {
                string newpath = FileHelper.GetConfigString("defaultPath");
                string writeContent = string.Format(@"copy " + currentDBFilePath + " " + newpath);
                BatHelper.WriteBat(path, writeContent);
            }
            if (BatHelper.RunBat(path))
                System.Windows.MessageBox.Show("数据库备份成功！");
        }

        /// <summary>
        /// 路径选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_OpenPath_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string path = FileHelper.OpenFolderPath();
                TB_Path.Text = path;
                if (!string.IsNullOrWhiteSpace(path.Trim()))
                {
                    string currentBatFilePath = System.AppDomain.CurrentDomain.BaseDirectory + "test.bat";
                    string currentDBFilePath = System.AppDomain.CurrentDomain.BaseDirectory + "test.sdf";
                    string writeContent = string.Format(@"copy " + currentDBFilePath + " " + path);
                    BatHelper.WriteBat(currentBatFilePath, writeContent);
                }
            }
            catch (Exception ex)
            {

            }
        }

        #region 备份目录选择
        /// <summary>
        /// 默认目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RB_DefaultPath_Checked(object sender, RoutedEventArgs e)
        {
            TB_Path.IsEnabled = false;
            Btn_OpenPath.IsEnabled = false;
        }

        /// <summary>
        /// 自定义目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RB_CuatomPath_Checked(object sender, RoutedEventArgs e)
        {
            TB_Path.IsEnabled = true;
            Btn_OpenPath.IsEnabled = true;
        }
        #endregion

        private void Btn_2_Click(object sender, RoutedEventArgs e)
        {
            Image_Contract.Source = ImageHepler.InitImage(@"F:\TestImage\1.jpg");
            Image_Contract2.Source = ImageHepler.InitImage(@"F:\TestImage\2.jpg");
        }

        #endregion

        /// <summary>
        /// 上传图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_OpenFile_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();
            ofd.DefaultExt = ".jpg";
            ofd.Filter = "jpg file|*.*";
            String nowtime = new DateTime().ToString("yyyy_MM_dd");
            String desfilename = @"C:\Users\Administrator\Desktop\test\";
            if (ofd.ShowDialog() == true)
            {
                String[] extName = ofd.FileName.Split('.');
                if (!Directory.Exists(desfilename))
                {
                    Directory.CreateDirectory(desfilename);  //创建目录
                }
                desfilename += nowtime + "." + extName[extName.Count()-1];
                File.Copy(ofd.FileName,desfilename);
                System.Windows.MessageBox.Show("图片上传成功！");
            }
        }
    }
}
