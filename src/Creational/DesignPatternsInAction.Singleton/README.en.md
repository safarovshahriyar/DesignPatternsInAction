# 🧩 Singleton Design Pattern (C#)

## 🔍 What is it?

The **Singleton pattern** ensures that a class has only **one instance** and provides a **global point of access** to that instance.

It is a **creational design pattern** used when exactly one object is needed to coordinate actions across the system.

---

## 🎯 Purpose

- Ensure that a single, shared instance is used across the application
- Prevent the creation of multiple instances for shared resources (e.g., logging, configuration)
- Control the lifecycle of a globally accessible object
- Provide **thread-safe and lazy-loaded access** in multi-threaded environments

---

## 🛠 Key Principles

### 1. **Encapsulation**
- The constructor is `private` to restrict external instantiation

### 2. **Lazy Initialization**
- The instance is created **only when it is first needed** (on-demand)

### 3. **Thread Safety**
- `Lazy<T>` or `lock` mechanisms ensure safe initialization across threads

---