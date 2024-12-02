import React, { useState } from 'react';

function App() {
  const [word, setWord] = useState('');
  const [translation, setTranslation] = useState('');
  const [error, setError] = useState('');

  const handleSubmit = async (e) => {
    e.preventDefault();
    setTranslation('');
    setError('');

    try {
      const response = await fetch(`https://localhost:7263/api/translation/${word}`);

      if (response.ok) {
        const translatedWord = await response.text();
        setTranslation(translatedWord);
      } else {
        setError('Translation not found');
      }
    } catch (err) {
      setError('Error occurred while fetching the translation');
    }
  };

  return (
    <div>
      <h1>Dictionary Translation</h1>
      <form onSubmit={handleSubmit}>
        <input
          type="text"
          value={word}
          onChange={(e) => setWord(e.target.value)}
          placeholder="Enter an English word"
        />
        <button type="submit">Translate</button>
      </form>

      {translation && <p>Translation: {translation}</p>}
      {error && <p>{error}</p>}
    </div>
  );
}

export default App;
