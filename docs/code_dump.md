`lblDisplay` = Display text


`Check the text on display is not Null, Empty, WhiteSpace`
```cs
if (String.IsNullOrEmpty(lblDisplay.Text) || String.IsNullOrWhiteSpace(lblDisplay.Text))
{
    this.lblDisplay.Text = "0";
    return;
}
```

`btnDel_Click`
`Remove the last part of the string from display`
```cs
int index = lblDisplay.Text.Length - 1;
int count = 1;
this.lblDisplay.Text = this.lblDisplay.Text.Remove(index, count);
```
