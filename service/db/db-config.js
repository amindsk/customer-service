//Importing dependencies
const config = require('config');
const firebase = require('firebase');

//Getting firebase configuration from default config
const firebaseConfig = config.get('firebaseConfig');

//Initializing firebase with default configuration
firebase.initializeApp(firebaseConfig);
const db = firebase.firestore();
db.settings({timestampsInSnapshots: true});

module.exports = {
    db
}