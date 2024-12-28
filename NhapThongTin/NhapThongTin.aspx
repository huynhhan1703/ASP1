<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NhapThongTin.aspx.cs" Inherits="NhapThongTin.NhapThongTin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
       
        .auto-style4 {
            text-align: center;
            background-color: #33CCFF;
            font-size: x-large;
            height: 34px;
        }
      
        .auto-style9 b {
            color: black;
            background:white;
       
        }
        /*.auto-style10 {
            height: 28px;
        }*/
    </style>
    <link href="Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container w-75 border border-black p-0">

            <table cellpadding="4" cellspacing="0" class="w-100 ">
                <tr>
                    <td colspan="2"  class='text-center fw-bold bg-info alert alert-danger h1 w-100'>ĐĂNG KÝ THÔNG TIN&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">Họ tên</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtHoTen" runat="server" CssClass="form-control"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Ngày sinh</td>
                    <td>
                        <asp:TextBox ID="txtNgaySinh" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">Giới tính</td>
                    <td class="auto-style10">
                        <asp:RadioButton ID="rdNam" runat="server" Text="Nam" GroupName="GT" Checked="true" />
                        <asp:RadioButton ID="rdNu" runat="server" Text="Nữ" GroupName="GT"/>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Trình độ </td>
                    <td>
                        <asp:DropDownList ID="ddlTrinhDo" runat="server" CssClass="form-select"  >
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Nghề nghiệp</td>
                    <td>
                        <asp:ListBox ID="lstNgheNghiep" runat="server" CssClass="form-select" required="true"></asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Hình</td>
                    <td>
                        <asp:FileUpload ID="FHinh" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Sở thích</td>
                    <td>
                        <asp:CheckBoxList ID="chkSoThich" runat="server">
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td class="text-center" colspan="2">
                        <asp:Button ID="btnGui" runat="server" Text="Gửi" CssClass="btn btn-primary" OnClick="btnGui_Click"/>
                        <asp:Button ID="btnLamLai" runat="server" Text="Làm lại" CssClass="btn btn-danger" OnClick="btnLamLai_Click" />
                    </td>
                </tr>            
                <tr>
                    <td class="auto-style9"colspan="2">
                        <asp:Label ID="lbThongTin" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
