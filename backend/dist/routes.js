"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.routes = void 0;
const express_1 = require("express");
const fs_1 = __importDefault(require("fs"));
const path_1 = __importDefault(require("path"));
const router = (0, express_1.Router)();
const dbPath = path_1.default.join(__dirname, '../db.json');
router.get('/ping', (req, res) => {
    res.send(true);
});
router.post('/submit', (req, res) => {
    const { name, email, phone, GithubLink, StopwatchTime } = req.body;
    const newSubmission = { name, email, phone, GithubLink, StopwatchTime };
    const data = JSON.parse(fs_1.default.readFileSync(dbPath, 'utf8'));
    data.submissions.push(newSubmission);
    fs_1.default.writeFileSync(dbPath, JSON.stringify(data, null, 2));
    res.status(200).send('Submission received');
});
router.get('/read', (req, res) => {
    const index = parseInt(req.query.index, 10);
    const data = JSON.parse(fs_1.default.readFileSync(dbPath, 'utf8'));
    if (index >= 0 && index < data.submissions.length) {
        res.json(data.submissions[index]);
    }
    else {
        res.status(404).send('Submission not found');
    }
});
router.put('/update', (req, res) => {
    const index = parseInt(req.query.index, 10);
    const { name, email, phone, GithubLink, StopwatchTime } = req.body;
    const updatedSubmission = { name, email, phone, GithubLink, StopwatchTime };
    const data = JSON.parse(fs_1.default.readFileSync(dbPath, 'utf8'));
    if (index >= 0 && index < data.submissions.length) {
        data.submissions[index] = updatedSubmission;
        fs_1.default.writeFileSync(dbPath, JSON.stringify(data, null, 2));
        res.status(200).send('Submission updated');
    }
    else {
        res.status(404).send('Submission not found');
    }
});
router.delete('/delete', (req, res) => {
    const index = parseInt(req.query.index, 10);
    const data = JSON.parse(fs_1.default.readFileSync(dbPath, 'utf8'));
    if (index >= 0 && index < data.submissions.length) {
        data.submissions.splice(index, 1);
        fs_1.default.writeFileSync(dbPath, JSON.stringify(data, null, 2));
        res.status(200).send('Submission deleted');
    }
    else {
        res.status(404).send('Submission not found');
    }
});
exports.routes = router;
