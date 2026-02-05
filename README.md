# 🚀 FiberStack - Hub de Serviços para OLTs

FiberStack é uma aplicação desenvolvida para centralizar e automatizar operações em OLTs (Optical Line Terminals), oferecendo um conjunto de serviços essenciais para provedores de internet, equipes de NOC e técnicos de rede.

A plataforma atua como um **hub de serviços**, permitindo a execução de tarefas comuns como consulta de clientes por Serial Number, limpeza de OLT, automação de comandos via SSH e persistência de dados utilizando Entity Framework Core.

---

## 📌 Funcionalidades

- 🔎 Busca de cliente por Serial Number (SN)
- 🧹 Limpeza de OLT (remoção de ONUs inativas ou inconsistentes)
- ⚙️ Execução de comandos remotos via SSH
- 📊 Persistência de dados utilizando Entity Framework Core
- 🔐 Gerenciamento de credenciais de acesso às OLTs
- 🧩 Arquitetura modular baseada em serviços

---

## 🏗️ Arquitetura

A aplicação segue uma arquitetura em camadas:

API
├── Controllers
├── Services
├── Domain
└── Infrastructure


- **Controllers**: Endpoints HTTP
- **Services**: Regras de negócio
- **Domain**: Acesso entidades e contratos
- **Infrastructure**: Integrações externas (SSH, banco de dados, etc.)

---

## 🛠️ Tecnologias Utilizadas

- .NET 8
- ASP.NET Core Web API
- Entity Framework Core (ORM)
- SSH.NET (Renci.SshNet)
- MySQL

---

## 📂 Estrutura de Pastas

FiberStack.Api
├── FiberStack.Api.Controllers
├── FiberStack.Api.Domain
├── ├── FiberStack.Api.Domain.Repository
├── └── FiberStack.Api.Domain.Interfaces
├── FiberStack.Api.Services
└── FiberStack.Api.Infrastructure
    └── FiberStack.Api.Persistence
        ├── FiberStack.Api.Persistence.Context
        ├── FiberStack.Api.Persistence.Repository
        └── FFiberStack.Api.Persistence.Migrations
    
