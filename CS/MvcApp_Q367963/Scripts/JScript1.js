var comboBox_value

function Button_OnClick(s, e) {
    comboBox_value = combo.GetValue();
    combo.PerformCallback();
}

function ComboBox_OnEndCallback(s, e) {
    s.SetValue(comboBox_value);
}