# 🧩 Singleton Design Pattern (C#)

## 🔍 Nədir?

**Singleton pattern** — obyekt yönümlü dizaynda bir sinifin yalnız **bir instansiyasının** mövcud olmasına **zəmanət verir** və bu instansiyaya **qlobal çıxış nöqtəsi** təmin edir.

Bu pattern, sistem daxilində **vahid və paylaşılan resursun** idarə olunması üçün istifadə olunur.

---

## 🎯 Məqsəd

- **Tək instansiyalı obyektlər** yaratmaq (e.g., `Logger`, `Config`, `Cache`)
- Obyektin həyat dövrünü (lifecycle) **tam nəzarət altında** saxlamaq
- Global obyektə çıxışı **idarə etmək**, amma **qlobal dəyişən kimi yox, nəzarətli şəkildə**
- **Multithreaded mühitlərdə** təhlükəsiz və performanslı obyekt paylaşımı təmin etmək

---

## 🛠 Texniki Prinsiplər

### 1. **Encapsulation**
- `Constructor` `private` edilir — instansiyanın kənardan yaradılması qadağandır.

### 2. **Lazy Initialization**
- Obyekt yalnız **ilk dəfə istifadə ediləndə** yaradılır (performans və resurs baxımından optimallaşdırma).

### 3. **Thread-Safety**
- Paralel (multi-threaded) mühitlərdə obyektin **bir dəfə** yaradıldığından əmin olmaq üçün `Lazy<T>` və ya `lock` istifadə olunur.

---
