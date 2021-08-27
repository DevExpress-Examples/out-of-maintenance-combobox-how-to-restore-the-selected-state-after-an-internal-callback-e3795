<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128549119/11.2.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3795)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/MvcApp_Q367963/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/MvcApp_Q367963/Controllers/HomeController.vb))
* [Model.cs](./CS/MvcApp_Q367963/Models/Model.cs) (VB: [Model.vb](./VB/MvcApp_Q367963/Models/Model.vb))
* [JScript1.js](./CS/MvcApp_Q367963/Scripts/JScript1.js) (VB: [JScript1.js](./VB/MvcApp_Q367963/Scripts/JScript1.js))
* [_PartialPage1.cshtml](./CS/MvcApp_Q367963/Views/Home/_PartialPage1.cshtml)
* [Index.cshtml](./CS/MvcApp_Q367963/Views/Home/Index.cshtml)
<!-- default file list end -->
# ComboBox - How to restore the selected state after an internal callback 
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e3795)**
<!-- run online end -->


<p>By design, the ComboBox resets the selected item after processing its own callback. We have a suggestion to change this behavior: <a href="https://www.devexpress.com/Support/Center/p/S19880">ASPxComboBox - Allow selection to be passed from server side to client side on its callback</a>.</p><p><br />
Currently, to set/restore the ComboBox's selection after a callback, perform the following steps:</p><p>1) Handle the client-side ASPxClientComboBox.EndCallback event;</p><p>2) Use the client-side ASPxClientComboBox.SetValue method to select the required item by its value.</p>

<br/>


