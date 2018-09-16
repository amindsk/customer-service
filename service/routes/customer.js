//Importing dependencies
const dbCustomers = require('../db/customers');

const { checkJwt } = require('../middleware/authenticate');


//Define all of the routes for customer service
const customerRouter = function (app) {

    //GET: customers with status Hot
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
module.exports = customerRouter;