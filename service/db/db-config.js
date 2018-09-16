var config = require('config');
var firebase = require('firebase');

var firebaseConfig = config.get('firebaseConfig');
firebase.initializeApp(firebaseConfig);
var db = firebase.firestore();
db.settings({timestampsInSnapshots: true});

module.exports = {
    db
}