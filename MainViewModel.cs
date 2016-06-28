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
            if (MessageBox.Show("您对这次服务满意吗，我只有听到你说满意才可以休眠(●—●)", "(●—●)休眠", MessageBoxButton.YesNoCancel) == MessageBoxResult.Yes)
                m_view.Close();
        }
        private void ShuDuReste()
        {

            ShuDu = new string[9, 9];
        }
        #endregion

        #region 初始构造
        public MainViewModel(IView view)
        {
            m_view = view;
            m_view.DataContext = this;
            CommandRun = new RelayCommand(ShuDuCalculateEasy);
            CommandReset = new RelayCommand(ShuDuReste);
            CommandMedium = new RelayCommand(ShuDuCalculateMedium);
            CommandClose = new RelayCommand(Close);
        }
        #endregion

        #region 简单算法
        public void ShuDuCalculateEasy()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (string.IsNullOrEmpty(MainModel.ShuDu[i, j]))
                    {
                        List<string> list = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

                        #region 行列宫排除
                        //排除列中数字
                        for (int row = 0; row < 9; row++)
                        {
                            if (list.Contains(MainModel.ShuDu[row, j]))
                            {
                                list.Remove(MainModel.ShuDu[row, j]);
                            }
                        }

                        //排除行中数字
                        for (int column = 0; column < 9; column++)
                        {
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
                                if (list.Contains(MainModel.ShuDu[row, column]))
                                {
                                    list.Remove(MainModel.ShuDu[row, column]);
                                }
                            }
                        }
                        #endregion

                        //获取唯一解
                        if (list.Count == 1)
                        {
                            #region 唯一解算法
                            MainModel.ShuDu[i, j] = list[0];
                            ShuDu = MainModel.ShuDu;
                            ShuDuCalculateEasy();
                            return;
                            #endregion
                        }
                        else
                        {
                            #region 行列夹逼算法
                            //把所求数位置宫格的其他行列整合分类，存储行号列号
                            List<string> list1, list2, list3, list4;
                            int row1, row2, column1, column2;
                            list1 = new List<string>();//row1
                            list2 = new List<string>();//row2
                            list3 = new List<string>();//column1
                            list4 = new List<string>();//column2
                            row1 = 0;
                            row2 = 0;
                            column1 = 0;
                            column2 = 0;
                            #region 准备工作，整合数据
                            //row1 ready
                            for (int row = (i / 3 * 3); row < (i / 3 * 3 + 2); row++)
                            {
                                if (row != i)
                                {
                                    for (int num = 0; num < 9; num++)
                                    {
                                        list1.Add(MainModel.ShuDu[row, num]);
                                    }
                                    row1 = row;
                                    break;
                                }
                            }
                            //row2
                            for (int row = (i / 3 * 3 + 2); row > (i / 3 * 3); row--)
                            {
                                if (row != i)
                                {
                                    for (int num = 0; num < 9; num++)
                                    {
                                        list2.Add(MainModel.ShuDu[row, num]);
                                    }
                                    row2 = row;
                                    break;
                                }
                            }
                            //column1
                            for (int column = (j / 3 * 3); column < (j / 3 * 3 + 2); column++)
                            {
                                if (column != j)
                                {
                                    for (int num = 0; num < 9; num++)
                                    {
                                        list3.Add(MainModel.ShuDu[num, column]);
                                    }
                                    column1 = column;
                                    break;
                                }
                            }
                            //column2
                            for (int column = (j / 3 * 3 + 2); column > (j / 3 * 3); column--)
                            {
                                if (column != j)
                                {
                                    for (int num = 0; num < 9; num++)
                                    {
                                        list4.Add(MainModel.ShuDu[num, column]);
                                    }
                                    column2 = column;
                                    break;
                                }
                            }

                            #endregion
                            //开始排除数
                            for (int count = 0; count < list.Count; count++)
                            {
                                #region 并排两行包含
                                //1,2contains. 3,4 contais or not null
                                if (list1.Contains(list[count]) && list2.Contains(list[count]))
                                {
                                    if ((list3.Contains(list[count]) || !string.IsNullOrEmpty(MainModel.ShuDu[i, column1])) && (list4.Contains(list[count]) || !string.IsNullOrEmpty(MainModel.ShuDu[i, column2])))
                                    {
                                        MainModel.ShuDu[i, j] = list[count];
                                        ShuDu = MainModel.ShuDu;
                                        ShuDuCalculateEasy();
                                        //MessageBox.Show("Ba~La~La~La~，我已经解答完毕，这样会改善您的心情吗？(●—●)", "(●—●)");
                                        return;
                                    }
                                }
                                //3,4contains. 1,2 contains or not null
                                if (list3.Contains(list[count]) && list4.Contains(list[count]))
                                {
                                    if ((list1.Contains(list[count]) || !string.IsNullOrEmpty(MainModel.ShuDu[row1, j])) && (list2.Contains(list[count]) || !string.IsNullOrEmpty(MainModel.ShuDu[row2, j])))
                                    {
                                        MainModel.ShuDu[i, j] = list[count];
                                        ShuDu = MainModel.ShuDu;
                                        ShuDuCalculateEasy();

                                        //MessageBox.Show("Ba~La~La~La~，我已经解答完毕，这样会改善您的心情吗？(●—●)", "(●—●)");

                                        return;
                                    }
                                }
                                #endregion
                                #region 交叉两行包含
                                //1,3 containts
                                if ((list1.Contains(list[count])) && (list3.Contains(list[count])) && (!string.IsNullOrEmpty(MainModel.ShuDu[i, column2])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row2, column2])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row2, j])))
                                {
                                    MainModel.ShuDu[i, j] = list[count];
                                    ShuDu = MainModel.ShuDu;
                                    ShuDuCalculateEasy();

                                    //MessageBox.Show("Ba~La~La~La~，我已经解答完毕，这样会改善您的心情吗？(●—●)", "(●—●)");

                                    return;
                                }

                                //1,4 contains
                                if ((list1.Contains(list[count])) && (list4.Contains(list[count])) && (!string.IsNullOrEmpty(MainModel.ShuDu[i, column1])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row2, column1])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row2, j])))
                                {
                                    MainModel.ShuDu[i, j] = list[count];
                                    ShuDu = MainModel.ShuDu;
                                    ShuDuCalculateEasy();

                                    //MessageBox.Show("Ba~La~La~La~，我已经解答完毕，这样会改善您的心情吗？(●—●)", "(●—●)");

                                    return;
                                }

                                //2,3 contains
                                if ((list2.Contains(list[count])) && (list3.Contains(list[count])) && (!string.IsNullOrEmpty(MainModel.ShuDu[i, column2])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row1, column2])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row1, j])))
                                {
                                    MainModel.ShuDu[i, j] = list[count];
                                    ShuDu = MainModel.ShuDu;
                                    ShuDuCalculateEasy();

                                    //MessageBox.Show("Ba~La~La~La~，我已经解答完毕，这样会改善您的心情吗？(●—●)", "(●—●)");

                                    return;
                                }
                                //2,4 contains
                                if ((list2.Contains(list[count])) && (list4.Contains(list[count])) && (!string.IsNullOrEmpty(MainModel.ShuDu[i, column1])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row1, column1])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row1, j])))
                                {
                                    MainModel.ShuDu[i, j] = list[count];
                                    ShuDu = MainModel.ShuDu;
                                    ShuDuCalculateEasy();

                                    //MessageBox.Show("Ba~La~La~La~，我已经解答完毕，这样会改善您的心情吗？(●—●)", "(●—●)");

                                    return;
                                }
                                #endregion
                                #region 只有单行包含

                                // 1 contains
                                if ((list1.Contains(list[count])) && (!string.IsNullOrEmpty(MainModel.ShuDu[i, column1])) && (!string.IsNullOrEmpty(MainModel.ShuDu[i, column2])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row2, column1])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row2, column2])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row2, j])))
                                {
                                    MainModel.ShuDu[i, j] = list[count];
                                    ShuDu = MainModel.ShuDu;
                                    ShuDuCalculateEasy();

                                    //MessageBox.Show("Ba~La~La~La~，我已经解答完毕，这样会改善您的心情吗？(●—●)", "(●—●)");

                                    return;
                                }
                                //2 contains
                                if ((list2.Contains(list[count])) && (!string.IsNullOrEmpty(MainModel.ShuDu[i, column1])) && (!string.IsNullOrEmpty(MainModel.ShuDu[i, column2])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row1, column1])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row1, column2])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row1, j])))
                                {
                                    MainModel.ShuDu[i, j] = list[count];
                                    ShuDu = MainModel.ShuDu;
                                    ShuDuCalculateEasy();

                                    //MessageBox.Show("Ba~La~La~La~，我已经解答完毕，这样会改善您的心情吗？(●—●)", "(●—●)");

                                    return;
                                }
                                //3 contains
                                if ((list3.Contains(list[count])) && (!string.IsNullOrEmpty(MainModel.ShuDu[i, column2])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row1, column2])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row1, j])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row2, column2])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row2, j])))
                                {
                                    MainModel.ShuDu[i, j] = list[count];
                                    ShuDu = MainModel.ShuDu;
                                    ShuDuCalculateEasy();

                                    //MessageBox.Show("Ba~La~La~La~，我已经解答完毕，这样会改善您的心情吗？(●—●)", "(●—●)");

                                    return;
                                }
                                //4 contains
                                if ((list4.Contains(list[count])) && (!string.IsNullOrEmpty(MainModel.ShuDu[i, column1])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row1, column1])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row1, j])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row2, column1])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row2, j])))
                                {
                                    MainModel.ShuDu[i, j] = list[count];
                                    ShuDu = MainModel.ShuDu;
                                    ShuDuCalculateEasy();

                                    //MessageBox.Show("Ba~La~La~La~，我已经解答完毕，这样会改善您的心情吗？(●—●)", "(●—●)");

                                    return;
                                }
                                #endregion
                            }
                            #endregion
                        }
                    }

                }
            }
        }
        #endregion
        #region 中等算法
        public void ShuDuCalculateMedium()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (string.IsNullOrEmpty(MainModel.ShuDu[i, j]))
                    {

                        List<string> list = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

                        #region 初级行列宫排除
                        //排除列中数字
                        for (int row = 0; row < 9; row++)
                        {
                            if (list.Contains(MainModel.ShuDu[row, j]))
                            {
                                list.Remove(MainModel.ShuDu[row, j]);
                            }
                        }

                        //排除行中数字
                        for (int column = 0; column < 9; column++)
                        {
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
                                if (list.Contains(MainModel.ShuDu[row, column]))
                                {
                                    list.Remove(MainModel.ShuDu[row, column]);
                                }
                            }
                        }
                        #endregion

                        //获取唯一解
                        if (list.Count == 1)
                        {
                            #region 初级唯一解算法
                            MainModel.ShuDu[i, j] = list[0];
                            ShuDu = MainModel.ShuDu;
                            ShuDuCalculateMedium();
                            return;
                            #endregion
                        }

                        else
                        {
                            #region 行列夹逼算法
                            //把所求数位置宫格的其他行列整合分类，存储行号列号
                            List<string> list1, list2, list3, list4;
                            int row1, row2, column1, column2;
                            list1 = new List<string>();//row1
                            list2 = new List<string>();//row2
                            list3 = new List<string>();//column1
                            list4 = new List<string>();//column2
                            row1 = 0;
                            row2 = 0;
                            column1 = 0;
                            column2 = 0;
                            #region 准备工作，整合数据
                            //row1 ready
                            for (int row = (i / 3 * 3); row < (i / 3 * 3 + 2); row++)
                            {
                                if (row != i)
                                {
                                    for (int num = 0; num < 9; num++)
                                    {
                                        list1.Add(MainModel.ShuDu[row, num]);
                                    }
                                    row1 = row;
                                    break;
                                }
                            }
                            //row2
                            for (int row = (i / 3 * 3 + 2); row > (i / 3 * 3); row--)
                            {
                                if (row != i)
                                {
                                    for (int num = 0; num < 9; num++)
                                    {
                                        list2.Add(MainModel.ShuDu[row, num]);
                                    }
                                    row2 = row;
                                    break;
                                }
                            }
                            //column1
                            for (int column = (j / 3 * 3); column < (j / 3 * 3 + 2); column++)
                            {
                                if (column != j)
                                {
                                    for (int num = 0; num < 9; num++)
                                    {
                                        list3.Add(MainModel.ShuDu[num, column]);
                                    }
                                    column1 = column;
                                    break;
                                }
                            }
                            //column2
                            for (int column = (j / 3 * 3 + 2); column > (j / 3 * 3); column--)
                            {
                                if (column != j)
                                {
                                    for (int num = 0; num < 9; num++)
                                    {
                                        list4.Add(MainModel.ShuDu[num, column]);
                                    }
                                    column2 = column;
                                    break;
                                }
                            }

                            #endregion
                            //开始排除数
                            for (int count = 0; count < list.Count; count++)
                            {
                                #region 并排两行包含
                                //1,2contains. 3,4 contais or not null
                                if (list1.Contains(list[count]) && list2.Contains(list[count]))
                                {
                                    if ((list3.Contains(list[count]) || !string.IsNullOrEmpty(MainModel.ShuDu[i, column1])) && (list4.Contains(list[count]) || !string.IsNullOrEmpty(MainModel.ShuDu[i, column2])))
                                    {
                                        MainModel.ShuDu[i, j] = list[count];
                                        ShuDu = MainModel.ShuDu;
                                        ShuDuCalculateMedium();
                                        //MessageBox.Show("Ba~La~La~La~，我已经解答完毕，这样会改善您的心情吗？(●—●)", "(●—●)");
                                        return;
                                    }
                                }
                                //3,4contains. 1,2 contains or not null
                                if (list3.Contains(list[count]) && list4.Contains(list[count]))
                                {
                                    if ((list1.Contains(list[count]) || !string.IsNullOrEmpty(MainModel.ShuDu[row1, j])) && (list2.Contains(list[count]) || !string.IsNullOrEmpty(MainModel.ShuDu[row2, j])))
                                    {
                                        MainModel.ShuDu[i, j] = list[count];
                                        ShuDu = MainModel.ShuDu;
                                        ShuDuCalculateMedium();
                                        //MessageBox.Show("Ba~La~La~La~，我已经解答完毕，这样会改善您的心情吗？(●—●)", "(●—●)");

                                        return;
                                    }
                                }
                                #endregion
                                #region 交叉两行包含
                                //1,3 containts
                                if ((list1.Contains(list[count])) && (list3.Contains(list[count])) && (!string.IsNullOrEmpty(MainModel.ShuDu[i, column2])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row2, column2])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row2, j])))
                                {
                                    MainModel.ShuDu[i, j] = list[count];
                                    ShuDu = MainModel.ShuDu;
                                    ShuDuCalculateMedium();
                                    //MessageBox.Show("Ba~La~La~La~，我已经解答完毕，这样会改善您的心情吗？(●—●)", "(●—●)");

                                    return;
                                }

                                //1,4 contains
                                if ((list1.Contains(list[count])) && (list4.Contains(list[count])) && (!string.IsNullOrEmpty(MainModel.ShuDu[i, column1])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row2, column1])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row2, j])))
                                {
                                    MainModel.ShuDu[i, j] = list[count];
                                    ShuDu = MainModel.ShuDu;
                                    ShuDuCalculateMedium();
                                    //MessageBox.Show("Ba~La~La~La~，我已经解答完毕，这样会改善您的心情吗？(●—●)", "(●—●)");

                                    return;
                                }

                                //2,3 contains
                                if ((list2.Contains(list[count])) && (list3.Contains(list[count])) && (!string.IsNullOrEmpty(MainModel.ShuDu[i, column2])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row1, column2])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row1, j])))
                                {
                                    MainModel.ShuDu[i, j] = list[count];
                                    ShuDu = MainModel.ShuDu;
                                    ShuDuCalculateMedium();
                                    //MessageBox.Show("Ba~La~La~La~，我已经解答完毕，这样会改善您的心情吗？(●—●)", "(●—●)");

                                    return;
                                }
                                //2,4 contains
                                if ((list2.Contains(list[count])) && (list4.Contains(list[count])) && (!string.IsNullOrEmpty(MainModel.ShuDu[i, column1])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row1, column1])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row1, j])))
                                {
                                    MainModel.ShuDu[i, j] = list[count];
                                    ShuDu = MainModel.ShuDu;
                                    ShuDuCalculateMedium();
                                    //MessageBox.Show("Ba~La~La~La~，我已经解答完毕，这样会改善您的心情吗？(●—●)", "(●—●)");

                                    return;
                                }
                                #endregion
                                #region 只有单行包含

                                // 1 contains
                                if ((list1.Contains(list[count])) && (!string.IsNullOrEmpty(MainModel.ShuDu[i, column1])) && (!string.IsNullOrEmpty(MainModel.ShuDu[i, column2])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row2, column1])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row2, column2])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row2, j])))
                                {
                                    MainModel.ShuDu[i, j] = list[count];
                                    ShuDu = MainModel.ShuDu;
                                    ShuDuCalculateMedium();
                                    //MessageBox.Show("Ba~La~La~La~，我已经解答完毕，这样会改善您的心情吗？(●—●)", "(●—●)");

                                    return;
                                }
                                //2 contains
                                if ((list2.Contains(list[count])) && (!string.IsNullOrEmpty(MainModel.ShuDu[i, column1])) && (!string.IsNullOrEmpty(MainModel.ShuDu[i, column2])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row1, column1])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row1, column2])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row1, j])))
                                {
                                    MainModel.ShuDu[i, j] = list[count];
                                    ShuDu = MainModel.ShuDu;
                                    ShuDuCalculateMedium();
                                    //MessageBox.Show("Ba~La~La~La~，我已经解答完毕，这样会改善您的心情吗？(●—●)", "(●—●)");

                                    return;
                                }
                                //3 contains
                                if ((list3.Contains(list[count])) && (!string.IsNullOrEmpty(MainModel.ShuDu[i, column2])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row1, column2])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row1, j])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row2, column2])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row2, j])))
                                {
                                    MainModel.ShuDu[i, j] = list[count];
                                    ShuDu = MainModel.ShuDu;
                                    ShuDuCalculateMedium();
                                    //MessageBox.Show("Ba~La~La~La~，我已经解答完毕，这样会改善您的心情吗？(●—●)", "(●—●)");

                                    return;
                                }
                                //4 contains
                                if ((list4.Contains(list[count])) && (!string.IsNullOrEmpty(MainModel.ShuDu[i, column1])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row1, column1])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row1, j])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row2, column1])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row2, j])))
                                {
                                    MainModel.ShuDu[i, j] = list[count];
                                    ShuDu = MainModel.ShuDu;
                                    ShuDuCalculateMedium();
                                    //MessageBox.Show("Ba~La~La~La~，我已经解答完毕，这样会改善您的心情吗？(●—●)", "(●—●)");

                                    return;
                                }
                                #endregion
                            }
                            #endregion
                        }

                        if (list.Count == 2)
                        {
                            #region 未知确定判定法
                            List<string> list1, list2, list3, list4;
                            int row1, row2, column1, column2;
                            list1 = new List<string>();//row 1
                            list2 = new List<string>();//row2
                            list3 = new List<string>();//column1
                            list4 = new List<string>();//column2
                            row1 = 0;
                            row2 = 0;
                            column1 = 0;
                            column2 = 0;

                            #region 排除确定夹逼未知
                            #region 列上寻找未知确定
                            //在列上寻找两个相同数，未知但必包含
                            for (int row = 0; row < 8; row++)
                            {
                                if (string.IsNullOrEmpty(MainModel.ShuDu[row, j]) && (string.IsNullOrEmpty(MainModel.ShuDu[row + 1, j])))
                                {
                                    if (row != 2 && row != 5 && row != i && row + 1 != i)//相连空格
                                    {
                                        #region 准备工作
                                        //找出相连空格宫中剩余的一行

                                        row1 = 0;
                                        row2 = 0;
                                        column1 = 0;
                                        column2 = 0;

                                        for (int hang = (row / 3 * 3); hang < (row / 3 * 3 + 3); hang++)
                                        {
                                            if (hang != row && hang != row + 1)
                                            {
                                                row1 = hang;
                                            }
                                        }
                                        //找出相连空格宫中剩余两列
                                        for (int column = (j / 3 * 3); column < (j / 3 * 3 + 2); column++)
                                        {
                                            if (column != j)
                                            {
                                                column1 = column;
                                                break;
                                            }
                                        }
                                        for (int column = (j / 3 * 3 + 2); column > (j / 3 * 3); column--)
                                        {
                                            if (column != j)
                                            {
                                                column2 = column;
                                                break;
                                            }
                                        }
                                        //把一行两列都整合到list中
                                        //把一行整合到list中
                                        list1 = new List<string>();//row 1
                                        list2 = new List<string>();//row2
                                        list3 = new List<string>();//column1
                                        list4 = new List<string>();//column2

                                        for (int num = 0; num < 9; num++)
                                        {
                                            list1.Add(MainModel.ShuDu[row1, num]);
                                        }
                                        //把其他两列整合到list中
                                        for (int num = 0; num < 9; num++)
                                        {
                                            list3.Add(MainModel.ShuDu[num, column1]);
                                        }
                                        for (int num = 0; num < 9; num++)
                                        {
                                            list4.Add(MainModel.ShuDu[num, column2]);
                                        }
                                        #endregion
                                        //整合完毕，开始判定是否能确定唯一解
                                        for (int count = 0; count < list.Count; count++)
                                        {
                                            if (list1.Contains(list[count]))
                                            {
                                                //3 contais
                                                if (list3.Contains(list[count]) && (!string.IsNullOrEmpty(MainModel.ShuDu[row, column2])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row + 1, column2])))
                                                {
                                                    if (IsNotContains(row1, column1, list[count]))
                                                    {
                                                        list.Remove(list[count]);
                                                        MainModel.ShuDu[i, j] = list[0];
                                                        ShuDu = MainModel.ShuDu;
                                                        ShuDuCalculateMedium();
                                                        return;
                                                    }

                                                }
                                                //4 contais
                                                if (list4.Contains(list[count]) && (!string.IsNullOrEmpty(MainModel.ShuDu[row, column1])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row + 1, column1])))
                                                {
                                                    if (IsNotContains(row1, column1, list[count]))
                                                    {
                                                        list.Remove(list[count]);
                                                        MainModel.ShuDu[i, j] = list[0];
                                                        ShuDu = MainModel.ShuDu;
                                                        ShuDuCalculateMedium();
                                                        return;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                            #region 行上寻找未知确定
                            for (int column = 0; column < 8; column++)
                            {
                                if (string.IsNullOrEmpty(MainModel.ShuDu[i, column]) && (string.IsNullOrEmpty(MainModel.ShuDu[i, column + 1])))
                                {
                                    if (column != 2 && column != 5 && column != j && column + 1 != j)//相连空格
                                    {
                                        #region 准备工作

                                        row1 = 0;
                                        row2 = 0;
                                        column1 = 0;
                                        column2 = 0;
                                        //找出相连空格宫中剩余的一列

                                        for (int lie = (column / 3 * 3); lie < (column / 3 * 3 + 3); lie++)
                                        {
                                            if (lie != column && lie != column + 1)
                                            {
                                                column1 = lie;
                                            }
                                        }
                                        //找出相连空格宫中剩余两行
                                        for (int row = (i / 3 * 3); row < (i / 3 * 3 + 2); row++)
                                        {
                                            if (row != i)
                                            {
                                                row1 = row;
                                                break;
                                            }
                                        }
                                        for (int row = (i / 3 * 3 + 2); row > (i / 3 * 3); row--)
                                        {
                                            if (row != i)
                                            {
                                                row2 = row;
                                                break;
                                            }
                                        }
                                        //把一列两行都整合到list中
                                        //把一列整合到list中
                                        list1 = new List<string>();//row 1
                                        list2 = new List<string>();//row2
                                        list3 = new List<string>();//column1
                                        list4 = new List<string>();//column2
                                        for (int num = 0; num < 9; num++)
                                        {
                                            list3.Add(MainModel.ShuDu[num, column1]);
                                        }
                                        //把其他两行整合到list中
                                        for (int num = 0; num < 9; num++)
                                        {
                                            list1.Add(MainModel.ShuDu[row1, num]);
                                        }
                                        for (int num = 0; num < 9; num++)
                                        {
                                            list2.Add(MainModel.ShuDu[row2, num]);
                                        }
                                        #endregion
                                        //整合完毕，开始判定是否能确定唯一解
                                        for (int count = 0; count < list.Count; count++)
                                        {
                                            if (list3.Contains(list[count]))
                                            {
                                                //3 contais
                                                if (list1.Contains(list[count]) && (!string.IsNullOrEmpty(MainModel.ShuDu[row2, column])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row2, column + 1])))
                                                {
                                                    if (IsNotContains(row1, column1, list[count]))
                                                    {
                                                        list.Remove(list[count]);
                                                        MainModel.ShuDu[i, j] = list[0];
                                                        ShuDu = MainModel.ShuDu;
                                                        ShuDuCalculateMedium();
                                                        return;
                                                    }

                                                }
                                                //4 contais
                                                if (list2.Contains(list[count]) && (!string.IsNullOrEmpty(MainModel.ShuDu[row1, column])) && (!string.IsNullOrEmpty(MainModel.ShuDu[row1, column + 1])))
                                                {
                                                    if (IsNotContains(row1, column1, list[count]))
                                                    {
                                                        list.Remove(list[count]);
                                                        MainModel.ShuDu[i, j] = list[0];
                                                        ShuDu = MainModel.ShuDu;
                                                        ShuDuCalculateMedium();
                                                        return;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                            #endregion
                            #endregion
                        }

                    }

                }
            }

        }
        #endregion

        #region 包含判定
        public bool IsNotContains(int row, int column, string str)
        {
            bool res = true; ;
            for (int i = (row / 3 * 3); i < (row / 3 * 3 + 3); i++)
            {
                for (int j = (column / 3 * 3); j < (column / 3 * 3 + 3); j++)
                {
                    if (MainModel.ShuDu[i, j] == str)
                    {
                        res = false;
                    }
                }
            }
            return res;

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
