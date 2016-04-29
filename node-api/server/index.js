'use strict'

let express = require('express');

let app = express();

app.get('/fact', (request, response) => {
  response.json({ content:"Chuck Norris doesn't read books. He stares them down until he gets the information he wants." });
});

app.listen(8000, () => {
  console.log('listening on 8000');
});
