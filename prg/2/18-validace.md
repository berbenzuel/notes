# Validace
validace údajů v různých prvcích winforms

example form: [github](https://github.com/berbenzuel/notes/tree/master/source/projects/WinFormsApp1)

## Příklad 1
Tento kód se dá použít ale není to hezké
```c#
public bool IsValid()
{
    var isValid = true;

    if (string.IsNullOrEmpty(this.textBox_Name.Text))
    {
        isValid = false;
        this.errorProvider1.SetError(this.textBox_Name, "name is empty");
    }
    if (string.IsNullOrEmpty(this.textBox_Surname.Text))
    {
        isValid = false;
        this.errorProvider1.SetError(this.textBox_Surname, "surname is empty");

    }
    return isValid;
}

private void button1_Click(object sender, EventArgs e)
{
    IsValid();
}
```



<!--stackedit_data:
eyJoaXN0b3J5IjpbLTQxMTQ4NTQyMiwtNDE1NTQyOTc5LC0xNT
QzODkyMTE4LC0xOTYzMDU3NDAwXX0=
-->