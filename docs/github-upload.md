# GitHub Upload

From the repository root:

```powershell
git init
git add .
git commit -m "Prepare pharmacy management app for GitHub"
git branch -M main
```

Then create an empty repository on GitHub and connect it:

```powershell
git remote add origin https://github.com/<your-user>/<your-repo>.git
git push -u origin main
```

If you use GitHub CLI:

```powershell
gh repo create <your-repo> --source . --private --push
```

Choose `--public` only when you are ready for the code and assets to be visible to everyone.
