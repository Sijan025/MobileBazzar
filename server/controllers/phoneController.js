const Phone = require('../models/Phone');
const multer = require('multer');
const path = require('path');

// Image upload configuration
const storage = multer.diskStorage({
  destination: (req, file, cb) => {
    cb(null, 'uploads/');
  },
  filename: (req, file, cb) => {
    cb(null, `${Date.now()}-${file.originalname}`);
  }
});

const upload = multer({ 
  storage,
  fileFilter: (req, file, cb) => {
    const filetypes = /jpeg|jpg|png/;
    const extname = filetypes.test(path.extname(file.originalname).toLowerCase();
    const mimetype = filetypes.test(file.mimetype);
    
    if (mimetype && extname) return cb(null, true);
    cb('Error: Images only!');
  }
}).array('images', 5);

exports.uploadPhoneImages = (req, res, next) => {
  upload(req, res, (err) => {
    if (err) return res.status(400).json({ success: false, message: err });
    next();
  });
};

exports.createPhone = async (req, res) => {
  try {
    const images = req.files.map(file => `/uploads/${file.filename}`);
    const phone = new Phone({
      ...req.body,
      images,
      seller: req.user.id
    });
    await phone.save();
    res.status(201).json({ success: true, data: phone });
  } catch (err) {
    res.status(400).json({ success: false, message: err.message });
  }
};

exports.getPhones = async (req, res) => {
  try {
    const { brand, minPrice, maxPrice, condition } = req.query;
    const query = {};
    
    if (brand) query.brand = brand;
    if (condition) query.condition = condition;
    if (minPrice || maxPrice) {
      query.price = {};
      if (minPrice) query.price.$gte = Number(minPrice);
      if (maxPrice) query.price.$lte = Number(maxPrice);
    }
    
    const phones = await Phone.find(query).populate('seller', 'name');
    res.status(200).json({ success: true, data: phones });
  } catch (err) {
    res.status(400).json({ success: false, message: err.message });
  }
};