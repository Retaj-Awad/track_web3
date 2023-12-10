Public Class Fuel_Shipment_Page
    Inherits System.Web.UI.Page

    Dim obj_fuel As New Fuel_Shipment_Class
    Dim obj_truck As New Truck_Class

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dt As DataTable = obj_truck.returncapacity(DropDownList4.SelectedValue)
        obj_fuel.AddFuel(DropDownList2.SelectedValue, dt.Rows(0).Item("transport_capacity"), DropDownList4.SelectedValue, DropDownList3.SelectedValue, "قيد التوصيل", Session("admin"))
        Label1.Visible = True
        Label1.ForeColor = Drawing.Color.Green
        Label1.Text = "تم إضافة بيانات الشحنة بنجاح"
        GridView1.DataBind()

    End Sub
End Class