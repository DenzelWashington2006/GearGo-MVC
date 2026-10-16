\# GearGo Business Analysis and Requirements (Issue #2)



\*\*Author:\*\* Bongi Kumalo (20251369)



\## 1. Problem Statement



\*\*Current problem:\*\* GearGo is a small equipment-rental business that rents camping equipment, power tools and event equipment. Customers cannot easily see what is available, and rental requests are handled informally, so bookings are missed or double-booked and stock records go out of date.



\*\*Affected users:\*\*

\- Customers, who cannot browse equipment or request rentals easily.

\- Staff, who spend time tracking equipment and rental requests by hand.

\- Managers, who lack control and oversight of the catalogue and users.



\*\*Business impact:\*\* Lost rentals, double-bookings, wasted staff time, unreliable stock information and a poor customer experience.



\*\*Proposed solution:\*\* A web application where customers browse available equipment and request rentals, staff manage equipment and process requests, and managers administer the catalogue and users.



\*\*Solution boundary:\*\*

\- In scope: equipment catalogue, rental requests, role-based access (Customer, Staff, Manager), basic user administration.

\- Out of scope: online payments, delivery logistics, invoicing, mobile app, stock forecasting.



\## 2. User Roles



| Role | Description |

|------|-------------|

| Customer | Browses equipment and requests rentals |

| Staff | Manages equipment and handles rental requests |

| Manager | Administers the catalogue and users, with full control |



\## 3. Use Cases



\### Customer

| ID | Use Case | Description |

|----|----------|-------------|

| UC-C1 | Browse equipment | View the list of equipment and its availability |

| UC-C2 | View equipment details | See description, category and daily rate |

| UC-C3 | Request a rental | Submit a rental request for chosen dates |

| UC-C4 | View my rental requests | Check the status of requests made |



\### Staff

| ID | Use Case | Description |

|----|----------|-------------|

| UC-S1 | Add equipment | Create a new equipment item |

| UC-S2 | Update equipment | Edit details, rate or availability |

| UC-S3 | Review rental requests | See all incoming requests |

| UC-S4 | Approve or reject request | Decide on a rental request |



\### Manager

| ID | Use Case | Description |

|----|----------|-------------|

| UC-M1 | Manage catalogue | Add, edit or remove any equipment |

| UC-M2 | Manage users | Create users and assign roles |

| UC-M3 | View all rentals | Oversee all rental requests and their status |

| UC-M4 | Remove equipment | Retire equipment no longer offered |



\## 4. Use-Case Diagram



```mermaid

flowchart LR

&#x20;   Customer(\[Customer])

&#x20;   Staff(\[Staff])

&#x20;   Manager(\[Manager])



&#x20;   subgraph GearGo System

&#x20;       C1(Browse equipment)

&#x20;       C2(View equipment details)

&#x20;       C3(Request a rental)

&#x20;       C4(View my rental requests)

&#x20;       S1(Add equipment)

&#x20;       S2(Update equipment)

&#x20;       S3(Review rental requests)

&#x20;       S4(Approve or reject request)

&#x20;       M1(Manage catalogue)

&#x20;       M2(Manage users)

&#x20;       M3(View all rentals)

&#x20;   end



&#x20;   Customer --- C1

&#x20;   Customer --- C2

&#x20;   Customer --- C3

&#x20;   Customer --- C4

&#x20;   Staff --- S1

&#x20;   Staff --- S2

&#x20;   Staff --- S3

&#x20;   Staff --- S4

&#x20;   Manager --- M1

&#x20;   Manager --- M2

&#x20;   Manager --- M3

```



\## 5. Scope Summary



\- \*\*Week 1:\*\* Equipment list and details (first vertical slice).

\- \*\*Later weeks:\*\* Database, rental requests, authentication and roles, validation.

