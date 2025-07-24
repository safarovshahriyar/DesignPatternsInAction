# 🧩 Prototype Design Pattern

## 🔍 What is it?

The **Prototype pattern** allows you to create new objects by **cloning an existing instance**, rather than instantiating a new one from scratch.

It is especially useful when object creation is **expensive**, **complex**, or must occur **at runtime with flexible variations**.

---

## 🎯 Intent

- Avoid the cost of repeatedly creating complex objects
- Allow runtime configuration and duplication of objects
- Provide flexibility in creating variations from a base model

---

## 🧱 Structure

| Component         | Responsibility |
|-------------------|----------------|
| `Prototype`        | Declares the cloning interface (`Clone`) |
| `ConcretePrototype`| Implements the cloning logic |
| `Client`           | Uses the clone method to create new instances |

---

## 🛠 Real-World Example – UI Component Cloning

In this project, we simulate cloning of reusable **UI components**:

- `Button`
- `Card`
- `Modal`

All components implement the `IUIComponent` interface, which includes:

- `Clone()`: creates a copy of the object
- `Render()`: simulates visual output

---

## ✅ Implementation Highlights

- Cloning is implemented via `Deep Copy` logic
- All component types override the `Clone()` method to ensure independence
- The demo shows how one template component can be reused to generate multiple versions

---