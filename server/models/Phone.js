const mongoose = require('mongoose');

const phoneSchema = new mongoose.Schema({
  brand: { type: String, required: true },
  model: { type: String, required: true },
  price: { type: Number, required: true },
  condition: { 
    type: String, 
    required: true,
    enum: ['New', 'Like New', 'Good', 'Fair']
  },
  storage: { type: String, required: true },
  description: { type: String },
  images: [{ type: String }],
  seller: { type: mongoose.Schema.Types.ObjectId, ref: 'User' },
  createdAt: { type: Date, default: Date.now }
});

module.exports = mongoose.model('Phone', phoneSchema);