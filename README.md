<img src="https://capsule-render.vercel.app/api?type=waving&color=ffa500&height=300&section=header&text=Localhost:Inha&fontSize=90" />

## 0. Index
1. [Tech Stack](#1-tech-stack)
2. [Environment](#2-environment)
3. [API](#3-api)
4. [Frontend](#4-backend)
5. [Collaborators](#5-collaborators)

</br>

## 1. Tech Stack
<img src="https://img.shields.io/badge/HTML-E34F26?style=for-the-badge&logo=HTML5&logoColor=white"> <img src="https://img.shields.io/badge/CSS-1572B6?style=for-the-badge&logo=CSS3&logoColor=white"> <img src="https://img.shields.io/badge/Javascript-F7DF1E?style=for-the-badge&logo=Javascript&logoColor=black"> <img src="https://img.shields.io/badge/Blazor-512BD4?style=for-the-badge&logo=Blazor&logoColor=white"> <img src="https://img.shields.io/badge/SpringBoot-6DB33F?style=for-the-badge&logo=SpringBoot&logoColor=white">

</br>

## 2. Environment

- *(IDE: Visual Studio 2022 & Rider 2023.1.2)*
- *(Framework: .NET 7.0)*
- Language: C#, HTML, CSS, JS
- Using Library:
  

</br>

## 3. API

| Type | Function | Method | URL | Parameter | Dto | Return |
| :---: | --- | --- | --- | --- | --- | --- |
| Account | validate | POST | /api/account/validate | | AccountRequestDto | ResponseEntity.ok |
| | signUp | POST | /api/account/signup | | AccountRequestDto | ResponseEntity.ok |
| | signIn | POST | /api/account/signin | | AccountRequestDto | ResponseEntity.ok |
| for Debug | | | | | | |
| Account | GET | testValidate | /api/test/account/validate | ?id={id} | | ResponseEntity.ok |
| | GET | testSignUp | /api/test/account/signup | ?id={id}&pw={pw} | | ResponseEntity.ok |
| | GET | testSignIn | /api/test/account/signin | ?id={id}&pw={pw} | | ResponseEntity.ok |

| Dto | Data | Type |
| --- | --- | --- |
| AccountRequestDto | id | String |
| | pw | String |

| Response | Value |
| --- | --- |
| ResponseEntity.ok | true |
| | false |

</br>

## 4. Backend
- https://github.com/Baebin/LocalhostInha_backend

</br>

## 5. Collaborators
| ID | Develop Part |
| --- | :---: |
| [Aspyn04](https://github.com/Aspyn04) | UI |
| [Baebin](https://github.com/Baebin) | Backend |
| [Chickenkjw](https://github.com/Chickenkjw) | Frontend |
| [Jban1001](https://github.com/Jban1001) | UI |
| [Raymond1203](https://github.com/Raymond1203) | Undefined |