using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.ComponentModel;
using System.Windows;

namespace 饼饼爱稳稳数独求解
{
    public class MainViewModel : IViewModel, INotifyPropertyChanged
    {
        #region 候选数
        /// <summary>
        /// 候选数
        /// </summary>
        private List<string>[,] AvailableList = new List<string>[9, 9];
        #endregion

        #region 公共属性
        public string[,] ShuDu
        {
            get { return MainModel.ShuDu; }
            set
            {
                if (value != null)
                {
                    MainModel.ShuDu = value;
                    this.RaiseProperty("ShuDu");
                    this.RaiseProperty("ShuDu00");
                    this.RaiseProperty("ShuDu01");
                    this.RaiseProperty("ShuDu02");
                    this.RaiseProperty("ShuDu03");
                    this.RaiseProperty("ShuDu04");
                    this.RaiseProperty("ShuDu05");
                    this.RaiseProperty("ShuDu06");
                    this.RaiseProperty("ShuDu07");
                    this.RaiseProperty("ShuDu08");
                    this.RaiseProperty("ShuDu10");
                    this.RaiseProperty("ShuDu11");
                    this.RaiseProperty("ShuDu12");
                    this.RaiseProperty("ShuDu13");
                    this.RaiseProperty("ShuDu14");
                    this.RaiseProperty("ShuDu15");
                    this.RaiseProperty("ShuDu16");
                    this.RaiseProperty("ShuDu17");
                    this.RaiseProperty("ShuDu18");
                    this.RaiseProperty("ShuDu20");
                    this.RaiseProperty("ShuDu21");
                    this.RaiseProperty("ShuDu22");
                    this.RaiseProperty("ShuDu23");
                    this.RaiseProperty("ShuDu24");
                    this.RaiseProperty("ShuDu25");
                    this.RaiseProperty("ShuDu26");
                    this.RaiseProperty("ShuDu27");
                    this.RaiseProperty("ShuDu28");
                    this.RaiseProperty("ShuDu30");
                    this.RaiseProperty("ShuDu31");
                    this.RaiseProperty("ShuDu32");
                    this.RaiseProperty("ShuDu33");
                    this.RaiseProperty("ShuDu34");
                    this.RaiseProperty("ShuDu35");
                    this.RaiseProperty("ShuDu36");
                    this.RaiseProperty("ShuDu37");
                    this.RaiseProperty("ShuDu38");
                    this.RaiseProperty("ShuDu40");
                    this.RaiseProperty("ShuDu41");
                    this.RaiseProperty("ShuDu42");
                    this.RaiseProperty("ShuDu43");
                    this.RaiseProperty("ShuDu44");
                    this.RaiseProperty("ShuDu45");
                    this.RaiseProperty("ShuDu46");
                    this.RaiseProperty("ShuDu47");
                    this.RaiseProperty("ShuDu48");
                    this.RaiseProperty("ShuDu50");
                    this.RaiseProperty("ShuDu51");
                    this.RaiseProperty("ShuDu52");
                    this.RaiseProperty("ShuDu53");
                    this.RaiseProperty("ShuDu54");
                    this.RaiseProperty("ShuDu55");
                    this.RaiseProperty("ShuDu56");
                    this.RaiseProperty("ShuDu57");
                    this.RaiseProperty("ShuDu58");
                    this.RaiseProperty("ShuDu60");
                    this.RaiseProperty("ShuDu61");
                    this.RaiseProperty("ShuDu62");
                    this.RaiseProperty("ShuDu63");
                    this.RaiseProperty("ShuDu64");
                    this.RaiseProperty("ShuDu65");
                    this.RaiseProperty("ShuDu66");
                    this.RaiseProperty("ShuDu67");
                    this.RaiseProperty("ShuDu68");
                    this.RaiseProperty("ShuDu70");
                    this.RaiseProperty("ShuDu71");
                    this.RaiseProperty("ShuDu72");
                    this.RaiseProperty("ShuDu73");
                    this.RaiseProperty("ShuDu74");
                    this.RaiseProperty("ShuDu75");
                    this.RaiseProperty("ShuDu76");
                    this.RaiseProperty("ShuDu77");
                    this.RaiseProperty("ShuDu78");
                    this.RaiseProperty("ShuDu80");
                    this.RaiseProperty("ShuDu81");
                    this.RaiseProperty("ShuDu82");
                    this.RaiseProperty("ShuDu83");
                    this.RaiseProperty("ShuDu84");
                    this.RaiseProperty("ShuDu85");
                    this.RaiseProperty("ShuDu86");
                    this.RaiseProperty("ShuDu87");
                    this.RaiseProperty("ShuDu88");

                }
            }
        }
        public string ShuDu00
        {
            get { return MainModel.ShuDu[0, 0]; }
            set { MainModel.ShuDu[0, 0] = value; }
        }
        public string ShuDu01
        {
            get { return MainModel.ShuDu[0, 1]; }
            set { MainModel.ShuDu[0, 1] = value; }
        }
        public string ShuDu02
        {
            get { return MainModel.ShuDu[0, 2]; }
            set { MainModel.ShuDu[0, 2] = value; }
        }
        public string ShuDu03
        {
            get { return MainModel.ShuDu[0, 3]; }
            set { MainModel.ShuDu[0, 3] = value; }
        }
        public string ShuDu04
        {
            get { return MainModel.ShuDu[0, 4]; }
            set { MainModel.ShuDu[0, 4] = value; }
        }
        public string ShuDu05
        {
            get { return MainModel.ShuDu[0, 5]; }
            set { MainModel.ShuDu[0, 5] = value; }
        }
        public string ShuDu06
        {
            get { return MainModel.ShuDu[0, 6]; }
            set { MainModel.ShuDu[0, 6] = value; }
        }
        public string ShuDu07
        {
            get { return MainModel.ShuDu[0, 7]; }
            set { MainModel.ShuDu[0, 7] = value; }
        }
        public string ShuDu08
        {
            get { return MainModel.ShuDu[0, 8]; }
            set { MainModel.ShuDu[0, 8] = value; }
        }
        public string ShuDu10
        {
            get { return MainModel.ShuDu[1, 0]; }
            set { MainModel.ShuDu[1, 0] = value; }
        }
        public string ShuDu11
        {
            get { return MainModel.ShuDu[1, 1]; }
            set { MainModel.ShuDu[1, 1] = value; }
        }
        public string ShuDu12
        {
            get { return MainModel.ShuDu[1, 2]; }
            set { MainModel.ShuDu[1, 2] = value; }
        }
        public string ShuDu13
        {
            get { return MainModel.ShuDu[1, 3]; }
            set { MainModel.ShuDu[1, 3] = value; }
        }
        public string ShuDu14
        {
            get { return MainModel.ShuDu[1, 4]; }
            set { MainModel.ShuDu[1, 4] = value; }
        }
        public string ShuDu15
        {
            get { return MainModel.ShuDu[1, 5]; }
            set { MainModel.ShuDu[1, 5] = value; }
        }
        public string ShuDu16
        {
            get { return MainModel.ShuDu[1, 6]; }
            set { MainModel.ShuDu[1, 6] = value; }
        }
        public string ShuDu17
        {
            get { return MainModel.ShuDu[1, 7]; }
            set { MainModel.ShuDu[1, 7] = value; }
        }
        public string ShuDu18
        {
            get { return MainModel.ShuDu[1, 8]; }
            set { MainModel.ShuDu[1, 8] = value; }
        }
        public string ShuDu20
        {
            get { return MainModel.ShuDu[2, 0]; }
            set { MainModel.ShuDu[2, 0] = value; }
        }
        public string ShuDu21
        {
            get { return MainModel.ShuDu[2, 1]; }
            set { MainModel.ShuDu[2, 1] = value; }
        }
        public string ShuDu22
        {
            get { return MainModel.ShuDu[2, 2]; }
            set { MainModel.ShuDu[2, 2] = value; }
        }
        public string ShuDu23
        {
            get { return MainModel.ShuDu[2, 3]; }
            set { MainModel.ShuDu[2, 3] = value; }
        }
        public string ShuDu24
        {
            get { return MainModel.ShuDu[2, 4]; }
            set { MainModel.ShuDu[2, 4] = value; }
        }
        public string ShuDu25
        {
            get { return MainModel.ShuDu[2, 5]; }
            set { MainModel.ShuDu[2, 5] = value; }
        }
        public string ShuDu26
        {
            get { return MainModel.ShuDu[2, 6]; }
            set { MainModel.ShuDu[2, 6] = value; }
        }
        public string ShuDu27
        {
            get { return MainModel.ShuDu[2, 7]; }
            set { MainModel.ShuDu[2, 7] = value; }
        }
        public string ShuDu28
        {
            get { return MainModel.ShuDu[2, 8]; }
            set { MainModel.ShuDu[2, 8] = value; }
        }
        public string ShuDu30
        {
            get { return MainModel.ShuDu[3, 0]; }
            set { MainModel.ShuDu[3, 0] = value; }
        }
        public string ShuDu31
        {
            get { return MainModel.ShuDu[3, 1]; }
            set { MainModel.ShuDu[3, 1] = value; }
        }
        public string ShuDu32
        {
            get { return MainModel.ShuDu[3, 2]; }
            set { MainModel.ShuDu[3, 2] = value; }
        }
        public string ShuDu33
        {
            get { return MainModel.ShuDu[3, 3]; }
            set { MainModel.ShuDu[3, 3] = value; }
        }
        public string ShuDu34
        {
            get { return MainModel.ShuDu[3, 4]; }
            set { MainModel.ShuDu[3, 4] = value; }
        }
        public string ShuDu35
        {
            get { return MainModel.ShuDu[3, 5]; }
            set { MainModel.ShuDu[3, 5] = value; }
        }
        public string ShuDu36
        {
            get { return MainModel.ShuDu[3, 6]; }
            set { MainModel.ShuDu[3, 6] = value; }
        }
        public string ShuDu37
        {
            get { return MainModel.ShuDu[3, 7]; }
            set { MainModel.ShuDu[3, 7] = value; }
        }
        public string ShuDu38
        {
            get { return MainModel.ShuDu[3, 8]; }
            set { MainModel.ShuDu[3, 8] = value; }
        }
        public string ShuDu40
        {
            get { return MainModel.ShuDu[4, 0]; }
            set { MainModel.ShuDu[4, 0] = value; }
        }
        public string ShuDu41
        {
            get { return MainModel.ShuDu[4, 1]; }
            set { MainModel.ShuDu[4, 1] = value; }
        }
        public string ShuDu42
        {
            get { return MainModel.ShuDu[4, 2]; }
            set { MainModel.ShuDu[4, 2] = value; }
        }
        public string ShuDu43
        {
            get { return MainModel.ShuDu[4, 3]; }
            set { MainModel.ShuDu[4, 3] = value; }
        }
        public string ShuDu44
        {
            get { return MainModel.ShuDu[4, 4]; }
            set { MainModel.ShuDu[4, 4] = value; }
        }
        public string ShuDu45
        {
            get { return MainModel.ShuDu[4, 5]; }
            set { MainModel.ShuDu[4, 5] = value; }
        }
        public string ShuDu46
        {
            get { return MainModel.ShuDu[4, 6]; }
            set { MainModel.ShuDu[4, 6] = value; }
        }
        public string ShuDu47
        {
            get { return MainModel.ShuDu[4, 7]; }
            set { MainModel.ShuDu[4, 7] = value; }
        }
        public string ShuDu48
        {
            get { return MainModel.ShuDu[4, 8]; }
            set { MainModel.ShuDu[4, 8] = value; }
        }
        public string ShuDu50
        {
            get { return MainModel.ShuDu[5, 0]; }
            set { MainModel.ShuDu[5, 0] = value; }
        }
        public string ShuDu51
        {
            get { return MainModel.ShuDu[5, 1]; }
            set { MainModel.ShuDu[5, 1] = value; }
        }
        public string ShuDu52
        {
            get { return MainModel.ShuDu[5, 2]; }
            set { MainModel.ShuDu[5, 2] = value; }
        }
        public string ShuDu53
        {
            get { return MainModel.ShuDu[5, 3]; }
            set { MainModel.ShuDu[5, 3] = value; }
        }
        public string ShuDu54
        {
            get { return MainModel.ShuDu[5, 4]; }
            set { MainModel.ShuDu[5, 4] = value; }
        }
        public string ShuDu55
        {
            get { return MainModel.ShuDu[5, 5]; }
            set { MainModel.ShuDu[5, 5] = value; }
        }
        public string ShuDu56
        {
            get { return MainModel.ShuDu[5, 6]; }
            set { MainModel.ShuDu[5, 6] = value; }
        }
        public string ShuDu57
        {
            get { return MainModel.ShuDu[5, 7]; }
            set { MainModel.ShuDu[5, 7] = value; }
        }
        public string ShuDu58
        {
            get { return MainModel.ShuDu[5, 8]; }
            set { MainModel.ShuDu[5, 8] = value; }
        }
        public string ShuDu60
        {
            get { return MainModel.ShuDu[6, 0]; }
            set { MainModel.ShuDu[6, 0] = value; }
        }
        public string ShuDu61
        {
            get { return MainModel.ShuDu[6, 1]; }
            set { MainModel.ShuDu[6, 1] = value; }
        }
        public string ShuDu62
        {
            get { return MainModel.ShuDu[6, 2]; }
            set { MainModel.ShuDu[6, 2] = value; }
        }
        public string ShuDu63
        {
            get { return MainModel.ShuDu[6, 3]; }
            set { MainModel.ShuDu[6, 3] = value; }
        }
        public string ShuDu64
        {
            get { return MainModel.ShuDu[6, 4]; }
            set { MainModel.ShuDu[6, 4] = value; }
        }
        public string ShuDu65
        {
            get { return MainModel.ShuDu[6, 5]; }
            set { MainModel.ShuDu[6, 5] = value; }
        }
        public string ShuDu66
        {
            get { return MainModel.ShuDu[6, 6]; }
            set { MainModel.ShuDu[6, 6] = value; }
        }
        public string ShuDu67
        {
            get { return MainModel.ShuDu[6, 7]; }
            set { MainModel.ShuDu[6, 7] = value; }
        }
        public string ShuDu68
        {
            get { return MainModel.ShuDu[6, 8]; }
            set { MainModel.ShuDu[6, 8] = value; }
        }
        public string ShuDu70
        {
            get { return MainModel.ShuDu[7, 0]; }
            set { MainModel.ShuDu[7, 0] = value; }
        }
        public string ShuDu71
        {
            get { return MainModel.ShuDu[7, 1]; }
            set { MainModel.ShuDu[7, 1] = value; }
        }
        public string ShuDu72
        {
            get { return MainModel.ShuDu[7, 2]; }
            set { MainModel.ShuDu[7, 2] = value; }
        }
        public string ShuDu73
        {
            get { return MainModel.ShuDu[7, 3]; }
            set { MainModel.ShuDu[7, 3] = value; }
        }
        public string ShuDu74
        {
            get { return MainModel.ShuDu[7, 4]; }
            set { MainModel.ShuDu[7, 4] = value; }
        }
        public string ShuDu75
        {
            get { return MainModel.ShuDu[7, 5]; }
            set { MainModel.ShuDu[7, 5] = value; }
        }
        public string ShuDu76
        {
            get { return MainModel.ShuDu[7, 6]; }
            set { MainModel.ShuDu[7, 6] = value; }
        }
        public string ShuDu77
        {
            get { return MainModel.ShuDu[7, 7]; }
            set { MainModel.ShuDu[7, 7] = value; }
        }
        public string ShuDu78
        {
            get { return MainModel.ShuDu[7, 8]; }
            set { MainModel.ShuDu[7, 8] = value; }
        }
        public string ShuDu80
        {
            get { return MainModel.ShuDu[8, 0]; }
            set { MainModel.ShuDu[8, 0] = value; }
        }
        public string ShuDu81
        {
            get { return MainModel.ShuDu[8, 1]; }
            set { MainModel.ShuDu[8, 1] = value; }
        }
        public string ShuDu82
        {
            get { return MainModel.ShuDu[8, 2]; }
            set { MainModel.ShuDu[8, 2] = value; }
        }
        public string ShuDu83
        {
            get { return MainModel.ShuDu[8, 3]; }
            set { MainModel.ShuDu[8, 3] = value; }
        }
        public string ShuDu84
        {
            get { return MainModel.ShuDu[8, 4]; }
            set { MainModel.ShuDu[8, 4] = value; }
        }
        public string ShuDu85
        {
            get { return MainModel.ShuDu[8, 5]; }
            set { MainModel.ShuDu[8, 5] = value; }
        }
        public string ShuDu86
        {
            get { return MainModel.ShuDu[8, 6]; }
            set { MainModel.ShuDu[8, 6] = value; }
        }
        public string ShuDu87
        {
            get { return MainModel.ShuDu[8, 7]; }
            set { MainModel.ShuDu[8, 7] = value; }
        }
        public string ShuDu88
        {
            get { return MainModel.ShuDu[8, 8]; }
            set { MainModel.ShuDu[8, 8] = value; }
        }

        #endregion

        #region 命令定义
        private IView m_view;
        public ICommand CommandRun { set; get; }
        public ICommand CommandMedium { set; get; }
        public ICommand CommandReset { set; get; }
        public ICommand CommandClose { set; get; }
        #endregion
        #region 命令方法
        private void Close()
        {
            SaveLastShudu();
            m_view.Close();
        }
        private void ShuDuReste()
        {
            if (MessageBox.Show("确定要清空吗？", "询问", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                ShuDu = new string[9, 9];
        }
        #endregion

        #region 初始构造
        public MainViewModel(IView view)
        {
            m_view = view;
            m_view.DataContext = this;
            CommandRun = new RelayCommand(Refuse);
            CommandReset = new RelayCommand(ShuDuReste);
            CommandMedium = new RelayCommand(CalShuduAll);
            CommandClose = new RelayCommand(Close);

            LoadLastShudu();
        }
        /// <summary>
        /// 加载最后一次数独
        /// </summary>
        private void LoadLastShudu()
        {
            try
            {
                string data = Properties.Settings.Default.LastShudu;
                if (!string.IsNullOrEmpty(data))
                {
                    var datas = data.Split(',');
                    for (int i = 0; i < 9; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            MainModel.ShuDu[i, j] = datas[j + i * 9];
                        }
                    }
                    ShuDu = MainModel.ShuDu;
                }
            }
            catch (Exception)
            {
            }
        }
        /// <summary>
        /// 保存最后一次数独
        /// </summary>
        private void SaveLastShudu()
        {
            try
            {
                string data = string.Empty;
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        data += MainModel.ShuDu[i, j] + ",";
                    }
                }
                Properties.Settings.Default.LastShudu = data;
                Properties.Settings.Default.Save();
            }
            catch (Exception)
            {
            }
        }
        #endregion

        #region 还原
        /// <summary>
        /// 尝试准确破解和试错破解
        /// </summary>
        private void CalShuduAll()
        {
            MainModel.PreShuDu.Push((string[,])MainModel.ShuDu.Clone());

            if (!CheckSudu())
                return;
            if (TryAvailable())
            {
                MessageBox.Show("恭喜，稳稳已经帮你搞定啦！");
            }
            else
            {
                MessageBox.Show("抱歉，饼饼已经尽力啦！");
            }
            ShuDu = MainModel.ShuDu;
        }

        private bool CheckSudu()
        {
            char start = 'A';
            int count = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (string.IsNullOrEmpty(ShuDu[i, j]))
                    {
                        count++;
                    }
                    else if (!GetAvailableList(i, j).Contains(ShuDu[i, j]))
                    {
                        MessageBox.Show(string.Format("数独初盘有冲突，请检查第{0}行，第{1}列", (char)(i + start), j + 1));
                        return false;
                    }
                }
            }
            if (count > 81 - 17)
                MessageBox.Show("数独初始数字<17个，答案不唯一");
            return true;
        }
        /// <summary>
        /// 还原
        /// </summary>
        public void Refuse()
        {
            if (MainModel.PreShuDu.Count > 0)
            {
                MainModel.ShuDu = MainModel.PreShuDu.Pop();
                ShuDu = MainModel.ShuDu;
            }
        }
        #endregion

        #region 候选数枚举试错
        private bool TryAvailable()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!string.IsNullOrEmpty(ShuDu[i, j]))
                        continue;
                    var ava = GetAvailableList(i, j);
                    if (ava.Count > 0)
                    {
                        bool res = false; ;
                        for (int index = 0; index < ava.Count; index++)
                        {
                            MainModel.ShuDu[i, j] = ava[index];
                            if (TryAvailable())
                            {
                                res = true;
                                break;
                            }
                            else
                            {
                                MainModel.ShuDu[i, j] = null;
                            }
                        }
                        return res;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// 获取位置候选数
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        private List<string> GetAvailableList(int i, int j)
        {
            List<string> list = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            #region 行列宫排除
            //排除列中数字
            for (int row = 0; row < 9; row++)
            {
                if (row == i)
                    continue;
                if (list.Contains(MainModel.ShuDu[row, j]))
                {
                    list.Remove(MainModel.ShuDu[row, j]);
                }
            }
            //排除行中数字
            for (int column = 0; column < 9; column++)
            {
                if (j == column)
                    continue;
                if (list.Contains(MainModel.ShuDu[i, column]))
                {
                    list.Remove(MainModel.ShuDu[i, column]);
                }
            }
            //排除宫中数字
            for (int row = (i / 3 * 3); row < (i / 3 * 3 + 3); row++)
            {
                for (int column = (j / 3 * 3); column < (j / 3 * 3 + 3); column++)
                {
                    if (row == i && column == j)
                        continue;
                    if (list.Contains(MainModel.ShuDu[row, column]))
                    {
                        list.Remove(MainModel.ShuDu[row, column]);
                    }
                }
            }
            #endregion
            return list;
        }
        #endregion

        #region INotify接口
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaiseProperty(string property)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        #endregion
    }
}
