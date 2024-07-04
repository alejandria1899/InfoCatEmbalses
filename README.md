# Info Cat Embalses

## Index

- [Description](#description)
- [Design](#design)
- [Technologies Used](#technologies-used)
- [Installation and Configuration](#installation-and-configuration)
- [Routes](#routes)
- [Functional Features](#functional-features)
- [Technical Features](#technical-features)
- [Project Developers](#project-developers)


## Description

The application allows users to visualize the current state of the internal basins of Catalonia, showing key data such as water level, stored volume, and the percentage of stored volume compared to the reservoir's total capacity. Our mission is to:
- Provide accurate and up-to-date data on the reservoirs.
- Promote awareness of the importance of water resources.
- Facilitate data-driven decision-making for governments, businesses, and citizens.

## Design

To see the complete design of the application, you can visit our [Mockup on Figma](https://www.figma.com/design/Syc6WSsElojyub37hdt74n/InfoCatEmbalses?node-id=0-1&t=vcxeJOXpPUZyGfoA-0).


## Technologies Used

### Frontend
- **Vue.js**: Used for building the user interface.
- **Vue Router**: For route management within the application.
- **Primevue**: For styling.
-  **[Vitest](https://github.com/vitejs/vitest)**: This project uses as the testing framework to run unit and integration tests.

### Backend
- **Swagger**: Used to consume the API.
- **.ASP.NET**: Used to build the API that provides the necessary data for the application.


## Installation and Configuration

### Prerequisites

- Node.js (version 14 or higher)
- Vue.js (version 3)
- .NET SDK (version 3.1 or higher)

### Installation

#### Frontend

1. Clone the repository:
    ```bash
    git clone https://github.com/hugoperez11/info-cat-embalses
    cd info-cat-embalses
    ```

2. Install dependencies:
    ```bash
    npm install
    ```

3. Start the development server:
    ```bash
    npm run serve
    ```

#### Backend

1. Clone the repository:
    ```bash
    git clone https://github.com/alejandria1899/InfoCatEmbalses.git
    cd InfoCatEmbalses
    ```

The API will be available at `http://localhost:5045/swagger`.


## Routes

### Frontend

- `/Home`: Main page showing an overview of the reservoirs.
- `/About Us`: "About Us" page providing information about the project and the team.
- `/Contact`: "Contact" page providing a contact form.
- `/Search`: "Search" page providing information and data on the basins of Catalonia.

### Backend

- `/api/embalses`: Endpoint providing data on the reservoirs.

## Functional Features

- **Reservoir Status Visualization**: Displays water level, stored volume, and percentage of stored volume.
- **Intuitive Interface**: Clear and easy-to-use user interface built with Vue.js.
- **Real-Time Data**: Updated information on the status of the reservoirs.

## Technical Features

- **Modular Architecture**: Clear separation between frontend and backend for better maintainability.
- **Vue.js**: Use of modern technologies for a robust and scalable application.
- **RESTful API**: Backend built with .ASP.NET, following REST principles for easy integration.

## Project Developers

### Frontend
- Sara Terán: Scrum Master
- Esther P. Sarasua: Developer
- Conchy Pereira: Developer
- Belén Sanchez: Developer

### Backend
- Isamar Romero: Developer
- Roger Esteve: Product Owner
