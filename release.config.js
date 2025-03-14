const pkg = require('./package.json')

Date.prototype.yyyymmdd = function() {
  var mm = this.getMonth() + 1; // getMonth() is zero-based
  var dd = this.getDate();

  return [this.getFullYear(),
          (mm>9 ? '' : '0') + mm,
          (dd>9 ? '' : '0') + dd
         ].join('');
}

const date = new Date()
const timeZone = date.toLocaleString('en-US', { timeZone: 'America/Los_Angeles' })
const newDate = new Date(timeZone)
const dateFormat = newDate.yyyymmdd()

const presetConfig = {
  "types": [
    { "type": "feat", "section": "New Feature(s) 🚀" },
    { "type": "fix", "section": "Bug Fix(es) 🐛️" },
    { "type": "docs", "section": "Documentation Changes 📝" },
    { "type": "refactor", "section": "Code Refactoring 💅" },
    { "type": "style", "section": "Styles 🎨" },
    { "type": "perf", "section": "Performance Improvement(s) 🚄️" },
    { "type": "test", "section": "Tests 📡️" },
    { "type": "chore", "section": "Chores 🧹" },
    { "type": "build", "section": "Build System 🛠️" },
    { "type": "", "section": "Miscellaneous 🧩" }
  ]
}

module.exports = {
  "branches": [
     {"name": "main"},
     {"name": "qa", "channel": "qa", "prerelease": true}
  ],
  "plugins": [
    [
      "@semantic-release/commit-analyzer",
      {
        "preset": "conventionalcommits",
        "presetConfig": presetConfig,
        "releaseRules": [
          { breaking: true, release: 'major' },
          { type: 'feat', release: 'minor' },
          { type: 'feature', release: 'minor' },
          { type: 'fix', release: 'patch' },
          { type: 'style', release: 'patch' },
          { type: 'refactor', release: 'patch' },
          { type: 'perf', release: 'patch' },
          { type: 'build', release: 'patch' },
          { type: 'chore', release: 'patch' },
          { type: 'revert', release: 'patch' },
          { release: "patch" }
        ]
      }
    ],
    [
      "@semantic-release/release-notes-generator",
      {
        "preset": "conventionalcommits",
        "presetConfig": presetConfig,
      }
    ],
    [
      "@semantic-release/changelog",
      {
        "changelogFile": "CHANGELOG.md"
      }
    ],
    [
      "@semantic-release/git",
      {
        "assets": ["CHANGELOG.md", "package.json"],
        "message": "chore(release): ${nextRelease.version} [skip ci]\n\n${nextRelease.notes}"
      }
    ],
    ["@semantic-release/github", {
      "assets": [
        {"path": "build.zip", "label": "Build ZIP", "name": dateFormat + "-" + pkg.name + "-${ nextRelease.gitTag }.zip"}
      ]
    }]
  ],
  "ci": true
 }