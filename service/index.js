//Importing dependencies

const config = require('config');
const express = require("express");
const customerRoutes = require("./routes/customer");
const app = express();

//Welcome route to verify if service is up and running
app.get('/', (req, res) => {
    res.status(200).send('Welcome to customers service');
});

//Combining customer routes with other routes in application
customerRoutes(app);


//Setting port to run the service
const server = app.listen(process.env.port || config.get('apiPort'), function () {
    console.log("Customer service is running on ", server.address().port);
});