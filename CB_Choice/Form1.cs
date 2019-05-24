using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CB_Choice
{
    public partial class Form1 : Form
    {
        private string[] SList = new string[]{"치킨", "피자", "햄버거", "샌드위치" ,"사이다", "쿠키"};
        string orgStr = ""; // 선택 결과 저장

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < SList.Length; i++)
            {
                this.cbList.Items.Add(SList[i]);
            }
            this.orgStr = lblResult.Text;
            if (cbList.Items.Count > 0)
            {
                this.cbList.SelectedIndex = 0;
            }
        }

        private void CbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbList.Text != "")
            {
                this.lblResult.Text = orgStr + this.cbList.Text;
            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CheckInput();

        }

        private void TxtList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                CheckInput();
                e.Handled = true;
            }
        }

        private void CheckInput()
        {
            if (this.txtList.Text != "")
            {
                this.cbList.Items.Add(this.txtList.Text);
                MessageBox.Show("아이템을 추가하였습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtList.Text = "";
            }
            else
            {
                MessageBox.Show("아이템을 입력해주세요.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtList.Focus();
            }
        }
    }
}
