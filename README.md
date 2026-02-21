<div align="center">

# 🏛️ 
## Kurs Kayıt & Takip Sistemi

<br/>

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET Core](https://img.shields.io/badge/.NET_Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![MSSQL](https://img.shields.io/badge/MS_SQL_Server-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows_Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white)

<br/>

![GitHub repo size](https://img.shields.io/github/repo-size/emrecuni/BIGADIC_COURSE?style=flat-square&color=512BD4)
![GitHub last commit](https://img.shields.io/github/last-commit/emrecuni/BIGADIC_COURSE?style=flat-square&color=239120)
![GitHub commit activity](https://img.shields.io/github/commit-activity/m/emrecuni/BIGADIC_COURSE?style=flat-square&color=CC2927)
![GitHub top language](https://img.shields.io/github/languages/top/emrecuni/BIGADIC_COURSE?style=flat-square&color=0078D6)

<br/>

> Belediyesi bünyesinde düzenlenen kursların kayıt, takip ve raporlanmasını sağlayan; rol tabanlı erişim kontrolü ve kapsamlı loglama altyapısına sahip masaüstü yönetim uygulaması.

</div>

---

## 📋 İçindekiler

- [✨ Özellikler](#-özellikler)
- [🛠️ Kullanılan Teknolojiler](#️-kullanılan-teknolojiler)
- [🔐 Kullanıcı Yetkilendirme](#-kullanıcı-yetkilendirme)
- [📊 Raporlama & Dışa Aktarım](#-raporlama--dışa-aktarım)
- [👤 Geliştirici](#-geliştirici)

---

## ✨ Özellikler

<div align="center">

| 👨‍🎓 Öğrenci | 📚 Kurs | 👨‍🏫 Eğitmen |
|:---:|:---:|:---:|
| Kayıt Ekleme | Kurs Tanımlama | Eğitmen Ekleme |
| Bilgi Güncelleme | Program Yönetimi | Branş Yönetimi |
| Silme & Listeleme | Kontenjan Takibi | Atama & Listeleme |
| Kursa Kayıt | Aktif/Pasif Durum |  |

</div>

<br/>

```
✅ Öğrenci · Kurs · Eğitmen için tam CRUD işlemleri
✅ Rol tabanlı erişim kontrolü (Admin / Kullanıcı)
✅ OxyPlot ile görsel grafik raporları
✅ Excel ve PDF formatında dışa aktarım
✅ NLog ile uygulama geneli loglama
✅ Güvenli kullanıcı giriş ekranı (Login)
✅ MS SQL Server veritabanı entegrasyonu
```

---

## 🛠️ Kullanılan Teknolojiler

<div align="center">

| Katman | Teknoloji | Amaç |
|:---|:---|:---|
| **Platform** | .NET Core · Windows Forms | Masaüstü uygulama altyapısı |
| **Dil** | C# | Uygulama geliştirme |
| **Veritabanı** | MS SQL Server | Veri depolama ve yönetimi |
| **Grafik** | OxyPlot | Görsel raporlama & chart |
| **Dışa Aktarım** | Excel (EPPlus) · PDF | Rapor çıktısı |
| **Loglama** | NLog | Hata ve işlem kayıtları |
| **IDE** | Visual Studio 2022 | Geliştirme ortamı |

</div>

---

## 🔐 Kullanıcı Yetkilendirme

Uygulama, rol tabanlı erişim kontrolü (RBAC) sistemiyle çalışmaktadır. Giriş yapan kullanıcının yetkisine göre işlem kapsamı otomatik olarak belirlenir.

```
┌────────────────────────────────────────────────────────┐
│                   🔑 GİRİŞ EKRANI 🔑                  |
└──────────────────────┬─────────────────────────────────┘
                       │
          ┌────────────┴────────────┐
          │                         │
    👑 ADMİN                   👤 KULLANICI
          │                         │
  ✅ Ekleme                   ❌ Ekleme
  ✅ Güncelleme               ❌ Güncelleme
  ✅ Silme                    ❌ Silme
  ✅ Listeleme                ✅ Listeleme
  ✅ Raporlama                ✅ Raporlama
```

---

## 📊 Raporlama & Dışa Aktarım

<div align="center">

| 📈 Grafik Raporlar | 📤 Dışa Aktarım |
|:---:|:---:|
| ![OxyPlot](https://img.shields.io/badge/OxyPlot-Grafik_Görünümü-512BD4?style=flat-square) | ![Excel](https://img.shields.io/badge/Excel-.xlsx_Çıktısı-217346?style=flat-square&logo=microsoftexcel&logoColor=white) |
| Kurs bazlı kayıt istatistikleri | Öğrenci listesi |
| Cinsiyet kurs yükü dağılımı | Kurs raporları |
| Kayıt durumu dağılımı | ![PDF](https://img.shields.io/badge/PDF-.pdf_Çıktısı-EC1C24?style=flat-square&logo=adobeacrobatreader&logoColor=white) |

</div>

---

<div align="center">

## 👤 Geliştirici

**Emre Cuni**

[![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/emrecuni)

---
![Wave](https://raw.githubusercontent.com/mayhemantt/mayhemantt/Update/svg/Bottom.svg)

</div>
