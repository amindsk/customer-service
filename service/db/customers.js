//Importing dependencies
const { db } = require('./db-config');

//To get list of customers from firebase-firestore with status Hot
const getCustomers = async () => {
    var snapshot = await db.collection('Customers').where('Status', '==', 'Hot').get();
    return snapshot.docs.map(doc => doc.data());
}

module.exports = {
    getCustomers
}