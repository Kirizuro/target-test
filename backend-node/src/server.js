const express = require("express");
const mongoose = require("mongoose");
const cors = require("cors");
const dotenv = require("dotenv");

dotenv.config();

const router = require("./Routes");

const app = express();

mongoose.connect(
  `mongodb+srv://${process.env.MONGODB_USER}:${process.env.MONGODB_PASSWORD}@cluster0-5mfoa.mongodb.net/${process.env.MONGODB_COLLECTION}`,
  {
    useNewUrlParser: true,
    useUnifiedTopology: true,
    useFindAndModify: false
  }
);

app.use(cors());
app.use(express.json());
app.use(router);

const port = 3000;

app.listen(port, () => {
  console.log(`Servidor rodando na porta ${port}`);
});
