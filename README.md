# 🎓 Conceitos Essenciais de POO

Repositório com exemplos práticos e diretos dos conceitos fundamentais de Programação Orientada a Objetos em C#.

---

## ✅ Condições de implementação

| Nível    | Achievement           | Condição                                                                                      |
|----------|-----------------------|------------------------------------------------------------------------------------------------|
| 🥉 Bronze | Class Master          | Entender o conceito de **Classes e Objetos** - classe é molde, objeto é instância.            |
| 🥈 Silver | Data Protector        | Implementar **Encapsulamento** com `private`, `protected` e controle de acesso.               |
| 🥇 Gold   | Inheritance Guru      | Usar **Herança** com `virtual` e `override` para reutilizar código.                           |
| 💎 Platinum | Polymorphism Master | Dominar **Polimorfismo** - sobrescrita (runtime) e sobrecarga (compile-time).                |
| ⚔️ Extra | Abstraction Hero      | Trabalhar com **Abstração** - classes `abstract` e `interfaces`.                             |
| 🏆 Extra+ | Advanced Pro          | Dominar **Propriedades customizadas** e **Indexers** para acessar como arrays.               |

---

## 🚨 Restrições obrigatórias

| Achievement         | Restrição                                                                                     |
|---------------------|------------------------------------------------------------------------------------------------|
| Class Master        | Cada classe deve ter um propósito único e bem definido.                                       |
| Data Protector      | Dados privados DEVEM ser inacessíveis externamente - uso apenas via métodos públicos.        |
| Inheritance Guru    | Herança apenas quando há relacionamento lógico "É UM" - não forçar hierarquia desnecessária. |
| Polymorphism Master | `override` só funciona com `virtual` na base. Sobrecarga = mesmo nome, parâmetros diferentes.|
| Abstraction Hero    | Classes `abstract` NÃO podem ser instanciadas. Interfaces DEVEM ser totalmente implementadas.|
| Advanced Pro        | Indexers permitem acesso como arrays - `objeto[indice]`.                                      |

---

## 📚 Conceitos disponíveis

### 1️⃣ Classes e Objetos
**Classe** = Molde/Template | **Objeto** = Instância criada a partir da classe

### 2️⃣ Encapsulamento  
Modificadores: `public`, `private`, `protected`, `internal`

### 3️⃣ Herança
Classe base → classe derivada | `virtual` + `override`

### 4️⃣ Polimorfismo
Sobrescrita (runtime) | Sobrecarga (compile-time)

### 5️⃣ Abstração
Classes `abstract` | Interfaces

### 6️⃣ Propriedades e Indexers
Propriedades customizadas | Indexers `objeto[indice]`

---

## 🚀 Como executar

```bash
cd OPP
dotnet run
```

---

## 📂 Estrutura

```
OPP/
├── Examples/
│   ├── 01_ClassesObjetos.cs
│   ├── 02_Encapsulamento.cs
│   ├── 03_Heranca.cs
│   ├── 04_Polimorfismo.cs
│   ├── 05_Abstracao.cs
│   └── 06_PropriedadesIndexers.cs
└── Program.cs
```
