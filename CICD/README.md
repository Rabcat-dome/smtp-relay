# MailHog
## Deploy
```
git pull
docker-compose -f CICD/DEV.yml down
docker-compose -f CICD/DEV.yml build
docker-compose -f CICD/DEV.yml up
```
