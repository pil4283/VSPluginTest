using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorMainForm : Form
    {
        public CalculatorMainForm()
        {
            InitializeComponent();

            CStaticData.g_operator = string.Empty;
            CStaticData.g_number = "0";
            CStaticData.g_preNumber = 0;
        }

        /// <summary>
        /// 숫자 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberButtonClick(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                if (CStaticData.g_number == "0")
                {
                    if (btn.Text == "0")
                    {
                        return;
                    }
                    else
                    {
                        inputTextBox.Text = "";
                    }
                }
                inputTextBox.Text += btn.Text;
                CStaticData.g_number = inputTextBox.Text;
            }
            catch(Exception ex)
            {

            }
        }

        /// <summary>
        /// 숫자 직접입력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            CStaticData.g_number = inputTextBox.Text;
        }

        /// <summary>
        /// 기능버튼 클릭 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            calProgressLabel.Text += inputTextBox.Text + " " + btn.Text + " ";
            //계산버튼 첫 클릭 시 
            if (CStaticData.g_operator == string.Empty && btn.Text != "=")
            {
                MessageBox.Show(CStaticData.g_number);
                //오퍼레이터와 숫자만 저장하고 리턴
                CStaticData.g_operator = btn.Text;
                CStaticData.g_preNumber = double.Parse(CStaticData.g_number);
                CStaticData.g_number = "0";
                return;
            }
            else //두번째부터는 전에 입력한 오퍼레이터대로 계산 후 새로운 오퍼레이터와 계산된 숫자를 저장
            {
                Calculate();
                CStaticData.g_operator = btn.Text;
                CStaticData.g_number = "0";
            }
        }

        /// <summary>
        ///취소버튼 클릭 
        /// </summary>
        private void CancelButtonClick(object sender, EventArgs e)
        {
            //모든 값 초기화
            CStaticData.g_preNumber = 0;
            CStaticData.g_number = "0";
            CStaticData.g_operator = "";
            calProgressLabel.Text = "";
            inputTextBox.Text = "0";
        }

        /// <summary>
        /// 이퀄버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EqualButtonClick(object sender, EventArgs e)
        {
            Calculate();
            calProgressLabel.Text = "";
            CStaticData.g_operator = string.Empty;
        }

        /// <summary>
        /// 소수점 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DotButtonClick(object sender, EventArgs e)
        {
            if(!CStaticData.g_number.Contains("."))
            {
                CStaticData.g_number += ".";
                inputTextBox.Text = CStaticData.g_number;
            }
        }

        /// <summary>
        /// 계산
        /// </summary>
        private void Calculate()
        {
            switch (CStaticData.g_operator)
            {
                case "+":
                    CStaticData.g_number = (CStaticData.g_preNumber + double.Parse(CStaticData.g_number)).ToString();
                    inputTextBox.Text = CStaticData.g_number;
                    break;
                case "-":
                    CStaticData.g_number = (CStaticData.g_preNumber - double.Parse(CStaticData.g_number)).ToString();
                    inputTextBox.Text = CStaticData.g_number;
                    break;
                case "*":
                    CStaticData.g_number = (CStaticData.g_preNumber * double.Parse(CStaticData.g_number)).ToString();
                    inputTextBox.Text = CStaticData.g_number;
                    break;
                case "/":
                    CStaticData.g_number = (CStaticData.g_preNumber / double.Parse(CStaticData.g_number)).ToString();
                    inputTextBox.Text = CStaticData.g_number;
                    break;
                default:
                    //입력X
                    break;
            }
            CStaticData.g_preNumber = double.Parse(CStaticData.g_number);
        }
    }
}
