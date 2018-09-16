var { db } = require('./db-config');

var getCustomers = async () => {
    var snapshot = await db.collection('Customers').where('Status', '==', 'Hot').get();
    return snapshot.docs.map(doc => doc.data());
}

module.exports = {
    getCustomers
}