# 🧩 Prototype Design Pattern

## 🔍 Nədir?

**Prototype pattern** obyektin yeni instansiyasını **yenidən yaratmaq yerinə**, onun **mövcud nümunəsini klonlamaqla** əldə etməyə imkan verir.

Bu, obyektin **duplikasiyasını performanslı və struktur baxımından səmərəli** şəkildə həyata keçirmək üçün istifadə olunur.

---

## 🎯 Məqsəd

- Obyektin yaradılması **çətin, bahalı və ya kompleks** olduqda
- Fərqli konfiqurasiyalarla eyni obyektin **təkrar-təkrar yaradılması lazım gəldikdə**
- **Runtime-da dinamik klonlama** tələb olunduqda

---

## 🧱 Struktur

| Komponent          | Təsviri |
|--------------------|---------|
| `Prototype`        | Klonlanacaq obyektin interfeysi və ya abstrakt bazası |
| `ConcretePrototype`| Klonlamanı reallaşdıran sinif |
| `Client`           | Klonlamanı tələb edən tərəf |

---

## 🛠 Real Nümunə – UI Komponentlərin Klonlanması

Bu layihədə `IUIComponent` interfeysi ilə klonlana bilən UI komponentləri yaradılıb:

- `Button`
- `Card`
- `Modal`

### 🎯 Məqsəd:
Fərqli dizayn və ölçüdə UI komponentlərini sürətli şəkildə klonlayaraq fərqli tərtibatlar yaratmaq.

---

## ✅ İmplementasiya Xüsusiyyətləri

- Bütün komponentlər `IUIComponent` interfeysini reallaşdırır (`Clone()` və `Render()` metodları)
- Klonlanan obyektlər müstəqil nüsxələrdir (`deep copy`)
- `UIPrototypeDemo.cs` faylında real istifadəsi göstərilir

---