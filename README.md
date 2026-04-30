# ☕ Coffee Date Wheel

> Sevgilinle kahve buluşması planlamak için interaktif çark çevir uygulaması.

![.NET](https://img.shields.io/badge/.NET%208-512BD4?style=flat-square&logo=dotnet&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-Web%20API-blue?style=flat-square)
![License](https://img.shields.io/badge/license-MIT-green?style=flat-square)

---

## 🎯 Ne İşe Yarar?

Coffee Date Wheel, sevgilinle birlikte **4 aşamalı çark çevirerek** spontane bir kahve buluşması planı oluşturmanı sağlar:

| Çark | Seçim |
|------|-------|
| ☕ Kahve | Latte, Cappuccino, Türk Kahvesi, Mocha... |
| 📍 Mekan | Deniz kenarı, Rooftop, Kitapçı kafe, Boğaz kenarı... |
| 🎯 Aktivite | Kahve falı, Playlist yap, Mektup yaz, 20 Soru... |
| 💫 Mod | Romantik, Eğlenceli, Huzurlu, Maceracı... |

Her çark döndükten sonra sonuç kartlarda birikir. 4 çark da tamamlanınca sevgi mesajı ile planınız hazır!

---

## 🖼️ Ekran Görüntüsü

```
┌─────────────────────────────┐
│       ☕ Coffee Date Wheel   │
│    ┌───────────────────┐    │
│    │    ╭───────────╮   │    │
│    │   ╱  SPINNING   ╲  │    │
│    │  │    WHEEL     │  │    │
│    │   ╲            ╱   │    │
│    │    ╰───────────╯   │    │
│    └───────────────────┘    │
│      [ ✨ Çarkı Çevir ]      │
│                             │
│  ☕ Latte                    │
│  📍 Rooftop kafe             │
│  🎯 Kahve falı               │
│  💫 Romantik 💕              │
│                             │
│  ❤️ Seninle her an güzel     │
└─────────────────────────────┘
```

---

## 🛠️ Teknolojiler

- **Backend:** ASP.NET Core 8 Web API
- **Frontend:** Vanilla HTML/CSS/JS (wwwroot içinde serve ediliyor)
- **Çark:** HTML5 Canvas ile çizilmiş, CSS animasyonlu
- **Mimari:** Tek proje, ayrı frontend framework'e gerek yok

---

## 🚀 Kurulum

### Gereksinimler

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022+ veya VS Code

### Çalıştırma

```bash
# Repoyu klonla
git clone https://github.com/KULLANICI_ADIN/CoffeeDateWheel.git
cd CoffeeDateWheel

# Çalıştır
dotnet run
```

Tarayıcıda `https://localhost:5001` adresine git.

### Visual Studio ile

1. `CoffeeDateWheel.sln` dosyasını aç
2. **F5** bas
3. Tarayıcı otomatik açılacak

---

## 📡 API Endpoint'leri

| Method | Endpoint | Açıklama |
|--------|----------|----------|
| `GET` | `/api/datewheel/spin` | Rastgele bir date planı döner |
| `GET` | `/api/datewheel/coffees` | Tüm kahve listesi |
| `GET` | `/api/datewheel/places` | Tüm mekan listesi |
| `GET` | `/api/datewheel/activities` | Tüm aktivite listesi |

### Örnek Response — `/api/datewheel/spin`

```json
{
  "coffee": "Latte ☕",
  "place": "Rooftop kafe 🏙️",
  "activity": "Birlikte playlist yapalım 🎵",
  "mood": "Romantik 💕",
  "message": "Seninle her an güzel ❤️"
}
```

---

## 📁 Proje Yapısı

```
CoffeeDateWheel/
├── Controllers/
│   └── DateWheelController.cs    # API controller
├── Models/
│   └── DatePlan.cs               # Response model
├── wwwroot/
│   └── index.html                # Frontend (çark + UI)
├── Properties/
│   └── launchSettings.json
├── Program.cs                    # App configuration
├── Dockerfile                    # Container desteği
└── README.md
```

---

## 🐳 Docker ile Çalıştırma

```bash
docker build -t coffee-date-wheel .
docker run -p 8080:8080 coffee-date-wheel
```

Tarayıcıda `http://localhost:8080` adresine git.

---

## 🌐 Deploy

Railway, Azure App Service veya Render gibi platformlara deploy edilebilir. Detaylı bilgi için `Dockerfile` hazır.

---

## 📝 Lisans

MIT License — istediğin gibi kullan, değiştir, paylaş.

---

<p align="center">made with ❤️ and lots of ☕</p>
