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

## Příklad 2

takhle je to lepší


<!--stackedit_data:
eyJoaXN0b3J5IjpbLTE1NTg5NDUzNDgsLTQxNTU0Mjk3OSwtMT
U0Mzg5MjExOCwtMTk2MzA1NzQwMF19
-->