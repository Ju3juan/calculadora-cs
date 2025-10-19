# (TMP) -> calculadora-cs v0.0

## Add

### Del func
`lblDisplay` = Display text
`btnDel_Click` = -


`Check the text on display is not Null, Empty, WhiteSpace`
```cs
if (String.IsNullOrEmpty(lblDisplay.Text) || String.IsNullOrWhiteSpace(lblDisplay.Text))
{
    this.lblDisplay.Text = "0";
    return;
}
```

`Remove the last part of the string from display`
```cs
int index = lblDisplay.Text.Length - 1;
int count = 1;
this.lblDisplay.Text = this.lblDisplay.Text.Remove(index, count);
```

## `lblDisplay`

- `0`
- `1`
- `2`
- `3`
- `4`
- `5`
- `6`
- `7`
- `8`
- `9`
- `-`
- `+`
- `.`

## Update

- `ToggleHistorial()`
    - **Why?**: Visual sugar

## TODO

```cs
string connectionString = @"Data Source = .; Initial Catalog = Calc; Integrated Security = True; Encrypt=False TrustServerCertificate=True";
```
