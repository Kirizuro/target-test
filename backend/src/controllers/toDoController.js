const model = require("../models/post");

const toDoController = {
  async show(req, res) {
    try {
      const posts = await model.find({});

      return res.json({
        status: 200,
        posts: posts
      });
    } catch (error) {
      return error;
    }
  },

  async create(req, res) {
    try {
      const { title, description } = req.body;

      const newPost = await model.create({
        title,
        description
      });

      return res.json({
        newPost,
        status: 200
      });
    } catch (error) {
      return error;
    }
  },

  async update(req, res) {
    try {
      const body = req.body;

      await model.findByIdAndUpdate(
        { _id: body._id },
        {
          title: body.title,
          description: body.description
        }
      );

      res.json({
        message: "Atualização com sucesso",
        status: 200
      });
    } catch (error) {
      return error;
    }
  },

  async delete(req, res) {
    try {
      const { id } = req.body;

      await model.findByIdAndDelete({ _id: id });

      res.json({
        message: "Deletado com sucesso",
        status: 200
      });
    } catch (error) {
      return error;
    }
  }
};

module.exports = toDoController;
