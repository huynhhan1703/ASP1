using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NhapThongTin
{
    public partial class NhapThongTin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                KhoiTaoDuLieu();
            }

        }

        private void KhoiTaoDuLieu()
        {
            ddlTrinhDo.Items.Add(new ListItem("Trung cấp", "01"));
            ddlTrinhDo.Items.Add(new ListItem("Cao đẳng", "02"));
            ddlTrinhDo.Items.Add(new ListItem("Đại học", "03"));
            ddlTrinhDo.Items.Add(new ListItem("Sau đại học", "04"));

            lstNgheNghiep.Items.Add(new ListItem("Công Nhân", "01"));
            lstNgheNghiep.Items.Add(new ListItem("Bác sĩ", "02"));
            lstNgheNghiep.Items.Add(new ListItem("Giáo viên", "03"));
            lstNgheNghiep.Items.Add(new ListItem("Lập trình viên", "04"));
            lstNgheNghiep.Items.Add(new ListItem("Kỹ sư", "05"));
            lstNgheNghiep.Items.Add(new ListItem("Khác", "06"));

            chkSoThich.Items.Add(new ListItem("Mua sắm", "01"));
            chkSoThich.Items.Add(new ListItem("Xem Phim", "02"));
            chkSoThich.Items.Add(new ListItem("Du lịch", "03"));
            chkSoThich.Items.Add(new ListItem("Phượt", "04"));
            chkSoThich.Items.Add(new ListItem("Chơi game", "05"));

        }

        protected void btnGui_Click(object sender, EventArgs e)
        {
            string kq = "<div class='text-center fw-bold bg-info alert alert-danger p-0 m-0  h1'>KẾT QUẢ ĐĂNG KÝ </div> ";
            kq += string.Format("<ul> <li> Họ tên: <b> {0} </b>", txtHoTen.Text);
            kq += string.Format("<li> Ngày sinh: <b> {0} </b>", txtNgaySinh.Text);
            kq += string.Format("<li> Giới tính: <b> {0} </b>", (rdNam.Checked ? rdNam.Text : rdNu.Text));
            kq += string.Format("<li> Trình độ: <b> {0} </b>", ddlTrinhDo.SelectedItem.Text);
            kq += string.Format("<li> Nghề nghiệp: <b> {0} </b>", lstNgheNghiep.SelectedItem.Text);

            if (FHinh.HasFile)
            {
                string path = Server.MapPath("~/Upfile");
                string filename = FHinh.FileName;
                FHinh.SaveAs(path + "/" + filename);
                kq += string.Format("<li> Ảnh đại điện: <img src='/Upfile/{0}' width='200px'>", filename);
            }

            string sothich = "";
            foreach (ListItem item in chkSoThich.Items)
            {
                if (item.Selected)
                {
                    sothich += item.Text + "; ";
                }
            }
            kq += string.Format("<li> Sở thích: <b> {0}</b>", sothich);
            kq += "</ul>";
            lbThongTin.Text = kq;
        }

        protected void btnLamLai_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtNgaySinh.Text = "";
            rdNam.Checked = true;
            rdNu.Checked = false;
            ddlTrinhDo.SelectedIndex = 0;
            lstNgheNghiep.SelectedIndex = -1;
            foreach (ListItem item in chkSoThich.Items)
            {
                item.Selected = false;
            }
            lbThongTin.Text = "";
        }

        protected void lstNgheNghiep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}