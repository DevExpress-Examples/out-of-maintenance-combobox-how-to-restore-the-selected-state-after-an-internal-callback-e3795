# ComboBox - How to restore the selected state after an internal callback 


<p>By design, the ComboBox resets the selected item after processing its own callback. We have a suggestion to change this behavior: <a href="https://www.devexpress.com/Support/Center/p/S19880">ASPxComboBox - Allow selection to be passed from server side to client side on its callback</a>.</p><p><br />
Currently, to set/restore the ComboBox's selection after a callback, perform the following steps:</p><p>1) Handle the client-side ASPxClientComboBox.EndCallback event;</p><p>2) Use the client-side ASPxClientComboBox.SetValue method to select the required item by its value.</p>

<br/>


