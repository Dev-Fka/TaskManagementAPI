# Task Management API

A modular, clean architecture-based **Task Management API** built using **.NET 8**, **ASP.NET Core**, and **PostgreSQL**.  
This project is part of a professional upskilling journey — designed to reinforce best practices in backend architecture, microservices, and API design.

---

## 🚀 Project Overview
This API serves as a practical project to strengthen concepts like:
- Clean Architecture
- CQRS & Mediator Pattern
- EF Core with PostgreSQL
- Repository & Service Layers
- Middleware and Logging

---

## 🧱 Project Structure
src/
├── TaskManagementAPI.API/ → Presentation Layer (Controllers, Middleware)
├── TaskManagementAPI.Application/ → Application Layer (CQRS, DTOs, Interfaces)
├── TaskManagementAPI.Domain/ → Domain Entities & Core Logic
├── TaskManagementAPI.Infrastructure/ → EF Core, Repositories, PostgreSQL setup
├── TaskManagementAPI.Shared/ → Common Helpers, Models, Enums
└── TaskManagementAPI.Tests/ → Unit & Integration Tests

---

## 🧠 Current Learning Goals (Phase 1)
- ✅ ASP.NET Core fundamentals (Controllers, Middleware, Dependency Injection)
- ✅ Entity Framework Core (Code First with PostgreSQL)
- ✅ RESTful API design
- ✅ Swagger integration
- 🧩 Prepare for modular architecture & microservices

---

## 🧰 Tools & Dependencies
| Category | Tools |
|-----------|-------|
| Backend | .NET 8, ASP.NET Core |
| Database | PostgreSQL, EF Core |
| Logging | Serilog (planned) |
| Auth | JWT, IdentityServer (next phase) |
| Dev Tools | Visual Studio 2022, Swagger |
| Version Control | Git & GitHub |

🧩 Planned Technologies (To Be Added)

This project will gradually evolve into a fully modular, production-grade architecture.
Below are the technologies and concepts planned to be integrated in future phases:

Category	Planned Additions
Authentication & Security	JWT Authentication, IdentityServer, Role-based Authorization
Architecture	CQRS Pattern, MediatR, FluentValidation
Microservices & Messaging	RabbitMQ, MassTransit
Logging & Monitoring	Serilog (structured logging), Seq, HealthChecks
Caching & Performance	Redis, In-Memory Cache
Search & Analytics	ElasticSearch integration
Containerization & Deployment	Docker, Docker Compose, Kubernetes
DevOps	CI/CD pipeline (GitHub Actions planned)
Testing	xUnit, Moq for Unit Testing, Integration Tests
Front-End Integration	Vue 3 (future dashboard)
AI Integration	LLM-based task assistant module (experimental feature)
---

## 🧑‍💻 Author
**Fatih Kaan Avcı**  
Software Engineer at Petlas
Currently pursuing a Master’s in AI/ML  
Passionate about backend architectures, databases,front-end tech, and learning by doing.  

📍 Turkey  
🔗 [GitHub Profile](https://github.com/Dev-Fka)

---

## 🏁 License
This project is licensed under the MIT License.
