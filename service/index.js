var config = require('config');
var express = require("express");
var routes = require("./routes/arouter");
var app = express();

routes(app);

var server = app.listen(process.env.port || config.get('apiPort'), function () {
    console.log("app running on port.", server.address().port);
});