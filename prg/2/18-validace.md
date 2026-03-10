# Validace
validace údajů v různých prvcích winforms
[example form](https://github.com/berbenzuel/notes/blob/master/source/img/validation.png)

## Příklad 1
>[!NOTE]
> ff


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
eyJoaXN0b3J5IjpbLTQxNTU0Mjk3OSwtMTU0Mzg5MjExOCwtMT
k2MzA1NzQwMF19
-->