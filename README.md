## Info Cat Reservoirs

## Description
The application allows users to visualise the current status of the internal basins of Catalonia, displaying key data such as water level, volume of reservoirs 
and the percentage of volume of reservoirs compared to the total capacity of the reservoir.

## Technologies Used

### Frontend
- Vue.js**: Used for building the user interface.
- Vue Router**: For route management within the application.

### Backend
- Swagger**: Documentation system, development of the necessary API elements and data.
- C# + ASP.NET**: Open source web framework used to build the necessary data for the project.
- XUnit**: To perform and develop the unit test structure. 

 
## Installation and Configuration

### Prerequisites
- Node.js (version 14 or higher)
- .NET Core SDK (version 3.1 or higher)

### Installation

#### Frontend
1. Clone the repository:
    ````bash
    git clone https://github.com/hugoperez11/info-cat-embalses
    cd info-cat-embalses
    ```

2. Install the dependencies:
    ````bash
    npm install
    ```

3. Start the development server:
    ````bash
    npm run serve
    ```

#### Backend
1. Clone the repository:
    git clone https://github.com/alejandria1899/InfoCatEmbalses.git
    cd InfoCatEmbalses
   
The API will be available at `http://localhost:5045/swagger`.


## Project structure

## Paths

### Frontend

- Home`: Main page showing an overview of the reservoirs.
- `/About Us`: "About Us" page providing information about the project and the team.
- `/Contact`: "Contact" page providing a form.
- `/Search`: "Search" page providing information and data on the basins of Catalonia.

### Backend

- `/api/embalses`: Endpoint that provides data about the reservoirs.


## Functional Features

- Reservoir Status Display**: Shows the water level, the volume of water in the reservoir and the percentage of the volume of water in the reservoir.
- Intuitive Interface**: Clear and easy to use user interface, built with Vue.js.
- Real-Time Data**: Up-to-date information on the status of the reservoirs.

## Technical Features

- Modular Architecture**: Clear separation between frontend and backend for better maintainability.
- Vue.js**: Use of modern technologies for a robust and scalable application.
- RESTful API**: Backend built with .ASP.NET, following REST principles for easy integration.
