using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 설문조사
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = null;

            dt = new DataTable();

            this.dataGridView1.DataSource = dt;

            DataColumn colsex = new DataColumn("성별", typeof(string));
            DataColumn colage = new DataColumn("나이대", typeof(string));
            DataColumn colcare = new DataColumn("양육 여부", typeof(string));
            DataColumn colyears = new DataColumn("양육 기간", typeof(string));
            DataColumn coleffects = new DataColumn("입양 후 긍정적인 효과", typeof(string));
            DataColumn coladoption = new DataColumn("입양 여부", typeof(string));
            DataColumn colnoadoption = new DataColumn("입양하지 않는 이유", typeof(string));
            DataColumn colincident = new DataColumn("반려동물들에 대한 부정적인 사건 접한 여부", typeof(string));
            DataColumn colreason = new DataColumn("부정적인 이슈가 발생하는 이유", typeof(string));
            DataColumn coleffort = new DataColumn("반려동물에 대한 부정적인 인식을 없애기 위한 노력", typeof(string));

            dt.Columns.Add(colsex);
            dt.Columns.Add(colage);
            dt.Columns.Add(colcare);
            dt.Columns.Add(colyears);
            dt.Columns.Add(coleffects);
            dt.Columns.Add(coladoption);
            dt.Columns.Add(colnoadoption);
            dt.Columns.Add(colincident);
            dt.Columns.Add(colreason);
            dt.Columns.Add(coleffort);

            DataRow row = dt.NewRow();

            if (rbtn_female.Checked)
            {
                row["성별"] = "여자";
            }
            else if (rbtn_male.Checked)
            {
                row["성별"] = "남자";
            }

            if (rbtn_10.Checked)
            {
                row["나이대"] = "10대";
            }
            else if (rbtn_20.Checked)
            {
                row["나이대"] = "20대";
            }
            else if (rbtn_30.Checked)
            {
                row["나이대"] = "30대";
            }
            else if (rbtn_40.Checked)
            {
                row["나이대"] = "40대";
            }
            else if (rbtn_50.Checked)
            {
                row["나이대"] = "50대 이상";
            }

            if (rbtn_care.Checked)
            {
                row["양육 여부"] = "예";
            }
            else if (rbtn_nocare.Checked)
            {
                row["양육 여부"] = "아니오";
            }

            if (rbtn_0.Checked)
            {
                row["양육 기간"] = "0~3년";
            }
            else if (rbtn_3.Checked)
            {
                row["양육 기간"] = "3~6년";
            }
            if (rbtn_6.Checked)
            {
                row["양육 기간"] = "6~9년";
            }
            else if (rbtn_9.Checked)
            {
                row["양육 기간"] = "9년 이상";
            }

            row["입양 후 긍정적인 효과"] = textBox1.Text;

            if (rbtn_yes.Checked)
            {
                row["입양 여부"] = "예";
            }
            else if (rbtn_no.Checked)
            {
                row["입양 여부"] = "아니오";
            }

            if (rbtn_A.Checked)
            {
                row["입양하지 않는 이유"] = "양육할 시간이 없어서";
            }
            else if (rbtn_B.Checked)
            {
                row["입양하지 않는 이유"] = "개인 사정 때문에";
            }
            else if (rbtn_C.Checked)
            {
                row["입양하지 않는 이유"] = "동거하고 있는 사람(들)이 반대해서";
            }
            else if (rbtn_D.Checked)
            {
                row["입양하지 않는 이유"] = "잘 키울 자신이 없어서";
            }
            else if (rbtn_E.Checked)
            {
                row["입양하지 않는 이유"] = "기타";
            }

            if (rbtn_Y.Checked)
            {
                row["반려동물들에 대한 부정적인 사건 접한 여부"] = "예";
            }
            else if (rbtn_N.Checked)
            {
                row["반려동물들에 대한 부정적인 사건 접한 여부"] = "아니오";
            }

            if (rdbn1.Checked)
            {
                row["부정적인 이슈가 발생하는 이유"] = "반려동물을 소모품으로 생각해서";
            }
            else if (rdbn2.Checked)
            {
                row["부정적인 이슈가 발생하는 이유"] = "키울 여건이 사라져서";
            }
            else if (rdbn3.Checked)
            {
                row["부정적인 이슈가 발생하는 이유"] = "반려동물을 쉽게 입양할 수 있어서";
            }
            else if (rdbn4.Checked)
            {
                row["부정적인 이슈가 발생하는 이유"] = "동물 학대와 유기에 대한 처벌이 약해서";
            }
            else if (rdbn5.Checked)
            {
                row["부정적인 이슈가 발생하는 이유"] = "기타";
            }

            row["반려동물에 대한 부정적인 인식을 없애기 위한 노력"] = textBox2.Text;

            dt.Rows.Add(row);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder x = new StringBuilder();
            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            {
                x.AppendLine(
                "\"" + dgvr.Cells[0].Value.ToString() + "\"" + "," +
                "\"" + dgvr.Cells[1].Value.ToString() + "\"" + "," +
                "\"" + dgvr.Cells[2].Value.ToString() + "\"" + "," +
                "\"" + dgvr.Cells[3].Value.ToString() + "\"" + "," +
                "\"" + dgvr.Cells[4].Value.ToString() + "\"" + "," +
                "\"" + dgvr.Cells[5].Value.ToString() + "\"" + "," +
                "\"" + dgvr.Cells[6].Value.ToString() + "\"" + "," +
                "\"" + dgvr.Cells[7].Value.ToString() + "\"" + "," +
                "\"" + dgvr.Cells[8].Value.ToString() + "\"" + "," +
                "\"" + dgvr.Cells[9].Value.ToString() + "\"" + ",");
            }
            string Contents = x.ToString();
            MessageBox.Show("설문조사에 참여해 주셔서 감사합니다.");
            System.IO.File.AppendAllText(@"C:\Users\fuzzf\OneDrive\바탕 화면\설문조사\설문 결과.csv", Contents);
            Close();
        }
    }
}