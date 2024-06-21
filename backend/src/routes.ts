import { Router, Request, Response } from 'express';
import fs from 'fs';
import path from 'path';

const router = Router();
const dbPath = path.join(__dirname, '../db.json');

interface Submission {
    name: string;
    email: string;
    phone: string;
    GithubLink: string;
    StopwatchTime: string;
}

router.get('/ping', (req: Request, res: Response) => {
    res.send(true);
});

router.post('/submit', (req: Request, res: Response) => {
    const { name, email, phone, GithubLink, StopwatchTime } = req.body;
    const newSubmission: Submission = { name, email, phone, GithubLink, StopwatchTime };

    const data = JSON.parse(fs.readFileSync(dbPath, 'utf8'));
    data.submissions.push(newSubmission);
    fs.writeFileSync(dbPath, JSON.stringify(data, null, 2));

    res.status(200).send('Submission received');
});

router.get('/read', (req: Request, res: Response) => {
    const index = parseInt(req.query.index as string, 10);
    const data = JSON.parse(fs.readFileSync(dbPath, 'utf8'));

    if (index >= 0 && index < data.submissions.length) {
        res.json(data.submissions[index]);
    } else {
        res.status(404).send('Submission not found');
    }
});

router.put('/update', (req: Request, res: Response) => {
    const index = parseInt(req.query.index as string, 10);
    const { name, email, phone, GithubLink, StopwatchTime } = req.body;
    const updatedSubmission: Submission = { name, email, phone, GithubLink, StopwatchTime };

    const data = JSON.parse(fs.readFileSync(dbPath, 'utf8'));

    if (index >= 0 && index < data.submissions.length) {
        data.submissions[index] = updatedSubmission;
        fs.writeFileSync(dbPath, JSON.stringify(data, null, 2));
        res.status(200).send('Submission updated');
    } else {
        res.status(404).send('Submission not found');
    }
});


router.delete('/delete', (req: Request, res: Response) => {
    const index = parseInt(req.query.index as string, 10);
    const data = JSON.parse(fs.readFileSync(dbPath, 'utf8'));

    if (index >= 0 && index < data.submissions.length) {
        data.submissions.splice(index, 1);
        fs.writeFileSync(dbPath, JSON.stringify(data, null, 2));
        res.status(200).send('Submission deleted');
    } else {
        res.status(404).send('Submission not found');
    }
});

export const routes = router;
