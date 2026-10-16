\# GearGo MVC and Data Design (Issue #3)



\*\*Author:\*\* Bongi Kumalo (20251369)



\## 1. MVC Architecture



```mermaid

flowchart LR

&#x20;   B\[Browser] --> C\[Controller]

&#x20;   C --> S\[Service / Business Logic]

&#x20;   S --> D\[Data Access / Repository]

&#x20;   D --> DB\[(Database)]

&#x20;   C --> V\[View - Razor]

&#x20;   V --> B

&#x20;   C -.uses.-> M\[Model]

```



| Layer | Responsibility | GearGo example |

|-------|----------------|----------------|

| Browser | Sends requests, shows pages | User opens /Equipment |

| Controller | Handles the request, chooses the view | EquipmentController |

| Service | Business rules | Check equipment is available before a rental |

| Data Access | Reads and writes data | EquipmentRepository |

| Database | Stores data | Equipment, Users, RentalRequests tables |

| Model | Data structures passed around | Equipment |

| View | Razor pages that render HTML | Index.cshtml, Details.cshtml |



\## 2. First ERD



```mermaid

erDiagram

&#x20;   USER ||--o{ RENTAL\_REQUEST : makes

&#x20;   EQUIPMENT ||--o{ RENTAL\_REQUEST : "is requested in"



&#x20;   EQUIPMENT {

&#x20;       int Id PK

&#x20;       string Name

&#x20;       string Description

&#x20;       string Category

&#x20;       decimal DailyRate

&#x20;       bool IsAvailable

&#x20;   }



&#x20;   USER {

&#x20;       int Id PK

&#x20;       string FullName

&#x20;       string Email

&#x20;       string Role

&#x20;   }



&#x20;   RENTAL\_REQUEST {

&#x20;       int Id PK

&#x20;       int EquipmentId FK

&#x20;       int UserId FK

&#x20;       date StartDate

&#x20;       date EndDate

&#x20;       string Status

&#x20;       datetime RequestedOn

&#x20;   }

```



\## 3. Relationships



\- One user can make many rental requests. Each request belongs to one user.

\- One equipment item can appear in many rental requests over time. Each request is for one equipment item.

\- Role is Customer, Staff or Manager. Status is Pending, Approved or Rejected.



\## 4. Week 1 Scope



Only Equipment is built this week, using a hard-coded list. User and RentalRequest are added in later weeks.

