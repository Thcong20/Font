using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap03
{
    public partial class Lab03_03 : Form
    {
        public Lab03_03()
        {
            InitializeComponent();
        }

        private int stt = 0;
        List<string> maSoSinhVienList = new List<string>();

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenAddStudentForm();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                this.Close();
            }

        }


        private void AddMSSV(string mssv)
        {
            maSoSinhVienList.Add(mssv);
        }
        private void OpenAddStudentForm()
        {

            using (AddSinhVien formNhapLieu = new AddSinhVien())
            {
                formNhapLieu.listMSSV = maSoSinhVienList;
                if (formNhapLieu.ShowDialog() == DialogResult.OK)
                {

                    stt++;
                    string maSoSinhVien = formNhapLieu.MaSoSinhVien;
                    string tenSinhVien = formNhapLieu.TenSinhVien;
                    string khoa = formNhapLieu.Khoa;
                    float diemSinhVien = formNhapLieu.DiemSinhVien;
                    dgvStudent.Rows.Add(stt, maSoSinhVien, tenSinhVien, khoa, diemSinhVien);
                    AddMSSV(maSoSinhVien);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[1].Value != null)
                {
                    string tenSinhVien = dgvStudent.Rows[i].Cells[2].Value.ToString().ToLower();
                    if (tenSinhVien.Contains(searchText))
                    {
                        dgvStudent.Rows[i].Visible = true;
                    }
                    else
                    {
                        dgvStudent.Rows[i].Visible = false;
                    }

                }
            }
        }

        private void themMoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAddStudentForm();
        }



    }
}