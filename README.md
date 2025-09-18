
# 🪪 Reduction Card System

A simple **C# Windows Forms application** that applies automatic discounts based on the customer’s age.  
It generates a **facture (invoice)** with the reduced price and allows exporting it as a `.txt` file.  

---

## ✨ Features

- Enter **Name, Age, Product, and Price**  
- Automatic **discount calculation**:  
  - 🎓 18–22 years → **60% off**  
  - 👨 23–59 years → **20% off**  
  - 👴 60+ years → **70% off**  
- Generate and display an invoice (`Facture`)  
- Export invoice as a **.txt file**  
- Simple and elegant Windows Forms UI  

---

## 🖥️ Screenshots  

| Main Form | Generated Facture |  
|-----------|------------------|  
| ![Form1]() | ![Facture]() |  

*(Replace these placeholders with your own screenshots 📸)*  

---

## 🚀 Usage

1. Enter customer information:
   - Name  
   - Age  
   - Product  
   - Price  
2. Click **Submit**  
3. A new window opens showing the **facture with discount applied**  
4. Click **Download** to save it as a `.txt` file  

---

## 🧮 Discount Logic

```csharp
if (Age >= 18 && Age < 23)
    red = Price * 0.40;   // 60% off
else if (Age >= 23 && Age < 60)
    red = Price * 0.80;   // 20% off
else
    red = Price * 0.30;   // 70% off
```

---

## 📂 Project Structure

```
ReductionCardSystem/
│── Form1.cs         # Main input form
│── Facture.cs       # Invoice form with details
│── Rreduction.cs    # Reduction logic class
│── Program.cs       # Entry point
│── README.md        # Project documentation
```

---

## 💡 Future Improvements
- Add **PDF export** option  
- Improve **UI/UX design** with modern styles  
- Add more **discount rules** (student, employee, etc.)  
- Multi-language support (French, Arabic, English)  

---

## 👨‍💻 Author

Developed with ❤️ by **Marouan El Yassini**
