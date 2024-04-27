## Savol № 1 - SOLID Umumiy savollar

---

### SOLID haiqda umumiy tushuncha bering

---

### SOLID tamoyillar beshga bo'linadi. Bularning har birini ko'rib chiqadigan bo'lsak.

---

### S: Yagona javobgarlik printsipi (Single Responsibility Principle)
Unda aytilishicha,class faqat bitta sababga ko'ra o'zgarishi kerak, ya'ni u yagona mas'uliyatga ega bo'lishi kerak.
Birinchi bo'lib xato yo'lni ko'rib chiqaylik.

```
// Yagona javobgarlik printsipi ni buzadigan misol
public class User
{
    public string Name { get; set; }
    public void Save()
    {
        // Foydalanuvchini ma'lumotlar bazasiga saqlash uchun kod
    }
    public void SendEmail(string xabar)
    {
        // Foydalanuvchiga elektron pochta yuborish uchun kod
    }
}

```

Yuoqridagi misolda, User class foydalanuvchini ma'lumotlar bazasiga saqlash va elektron pochta yuborish uchun mas'uliyatni o'z ichiga oladi.
Bu Yagona javobgarlik printsipi ni buzadi, chunki classning bir nechta o'zgarish sabablari mavjud. 

```
// SRP ni amalda tartibga soladigan misol
public class User
{
    public string Name { get; set; }
}

public class UserRepository
{
    public void Save(User user)
    {
        // Foydalanuvchini ma'lumotlar bazasiga saqlash uchun kod
    }
}

public class EmailService
{
    public void SendEmail(User user, string message)
    {
        // Foydalanuvchiga elektron pochta yuborish uchun kod
    }
}

```
Endi, har bir classning faqat yagona mas'uliyati mavjud.

### O: Ochiq-yopiq printsip (Open-Closed Principle)
Ochiq-yopiq prinsipda ta’kidlanishicha, dasturiy ta’minot obyektlari (classlar, modullar va boshqalar) kengaytirish uchun ochiq, lekin o‘zgartirish
uchun yopiq bo‘lishi kerak. Bu tamoyilga erishish uchun abstraction va inheritancedan foydalanish qo‘l keladi.

```
//Ochiq-yopiq prinsip (Open-Closed Principle)ni buzadigan yomon misol
public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }
}

public class AreaCalculator
{
    public double CalculateArea(Rectangle rectangle)
    {
        return rectangle.Width * rectangle.Height;
    }
}

```

Agar siz doira maydonini hisoblashingiz kerak bo'lsa, classni o'zgartirishingiz kerak bo'ladi "AreaCalculator".

```
//Ochiq-yopiq prinsip (Open-Closed Principle)ga rioya qilish misoli
public abstract class Shape
{
    public abstract double Area();
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    
    public override double Area()
    {
        return Width * Height;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }
    
    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}

```


