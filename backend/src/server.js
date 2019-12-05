const express = require("express");
const mongoose = require("mongoose");
const cors = require("cors");

const router = require("./Routes");

const app = express();

mongoose.connect(
  "mongodb+srv://omnistack:omnistack@cluster0-5mfoa.mongodb.net/omnistack8?retryWrites=true&w=majority",
  {
    useNewUrlParser: true,
    useUnifiedTopology: true
  }
);

app.use(cors());
app.use(express.json());
app.use(router);

const port = process.env.PORT || 3000;

app.listen(port, () => {
  console.log(`Servidor rodando na porta ${port}`);
});
