const express = require('express');
const router = express.Router();
const phoneController = require('../controllers/phoneController');
const authMiddleware = require('../middleware/auth');

router.route('/')
  .get(phoneController.getPhones)
  .post(
    authMiddleware.protect,
    phoneController.uploadPhoneImages,
    phoneController.createPhone
  );

module.exports = router;