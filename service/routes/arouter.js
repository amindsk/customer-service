var dbCustomers = require('../db/customers');

var { checkJwt } = require('../middleware/authenticate');



var appRouter = function (app) {
    
    app.get("/", (req, res) => {
        res.status(200).send('Welcome');
    });

    app.get("/customers", checkJwt, async (req, res) => {
        var customers = await dbCustomers.getCustomers();
        if(customers.length > 0) {
            res.status(200).send(customers);
        }
        else{
            res.status(204).send('No customer data');
        }
    });
}
module.exports = appRouter;