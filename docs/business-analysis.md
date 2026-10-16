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

    Customer(\[Customer])

    Staff(\[Staff])

    Manager(\[Manager])



    subgraph GearGo System

        C1(Browse equipment)

        C2(View equipment details)

        C3(Request a rental)

        C4(View my rental requests)

        S1(Add equipment)

        S2(Update equipment)

        S3(Review rental requests)

        S4(Approve or reject request)

        M1(Manage catalogue)

        M2(Manage users)

        M3(View all rentals)

    end



    Customer --- C1

    Customer --- C2

    Customer --- C3

    Customer --- C4

    Staff --- S1

    Staff --- S2

    Staff --- S3

    Staff --- S4

    Manager --- M1

    Manager --- M2

    Manager --- M3

```



\## 5. Scope Summary



\- \*\*Week 1:\*\* Equipment list and details (first vertical slice).

\- \*\*Later weeks:\*\* Database, rental requests, authentication and roles, validation.

