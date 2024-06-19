"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
const express_1 = __importDefault(require("express"));
const body_parser_1 = __importDefault(require("body-parser"));
const routes_1 = require("./routes");
const app = (0, express_1.default)();
const PORT = 3000;
app.use(body_parser_1.default.json());
app.use('/', routes_1.routes);
app.get('/', (req, res) => {
    res.send('Server is Up and Running!');
});
app.listen(PORT, () => {
    console.log(`Server is running on http://localhost:${PORT}`);
});
